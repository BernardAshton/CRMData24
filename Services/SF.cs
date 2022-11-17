using System;
using System.Linq;
using System.Data;
using CRM_MVC.Models;
using System.IO;              // Directory Commands
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace CRM_MVC.Services
{
    public class SF // Shared Functions use public static to make them globally accessible
    {
        private static UserTableDBContext db;

        //public class CrmDB Db = new CrmDB();

        //---------------------------------------------------------------------------
        //    Return a fixed length string
        //---------------------------------------------------------------------------
        public static string FixLenStr(string lvInput, int lvLen)
        {
            lvInput = lvInput + "                                                 ";
            return lvInput.Substring(0, lvLen);
        }
        //---------------------------------------------------------------------------
        // Return the logged in user 
        //---------------------------------------------------------------------------
        public static string UserOnly()
        {
            string[] nodomainuser = new string[3]; // 0 and 1 entries
            string username = nodomainuser[0].Split('\\')[1];
            if (StartsWith('\\'))
            {
                nodomainuser[0] = username;
                // System.Web.HttpContext.User.Identity.Name.ToString().Split('\\');
            }
            return (nodomainuser[0]);
        }
        //---------------------------------------------------------------------------
        // Validate a UK Telephone Number
        // Returns an error message if there is an error or null if it is ok
        // Rules are: 
        //    1) Must not be blank.
        //    2) Must start with 0. 
        //    3) Only 0-9 or space is allowed. 
        //    4) Must be 11 digits.
        //---------------------------------------------------------------------------
        public static string ValidatePhoneNo(string PhoneNo)
        {
            string lvPhone = "", lvError = null;
            Char lvOne;
            if (PhoneNo == null)
            {
                lvError = "Error: Phone Number must be entered";
                return lvError;
            }
            for (var i = 0; i < PhoneNo.Length; i++)
            {
                lvOne = Convert.ToChar(PhoneNo.Substring(i, 1));
                if (Char.IsWhiteSpace(lvOne))
                {
                    continue;
                }
                if (Char.IsDigit(lvOne))
                {
                    lvPhone = lvPhone + lvOne;
                }
                else
                {
                    lvError = "Error: Phone Number must only contain digits (0-9) or spaces";
                    return lvError;
                }
            }
            if (!lvPhone.StartsWith("0"))
            {
                lvError = "Error: Phone Number must start with 0";
                return lvError;
            }
            if (lvPhone.Length < 11)
            {
                lvError = "Error: Phone Number must contain at least 11 digits";
                return lvError;
            }
            return lvError;
        }
        //---------------------------------------------------------------------------
        // Read the Outlook Email Signature
        // Returns nothing if it can't find the Signature File
        // Get the name of the Signature File from Web.Config now from System Options
        //---------------------------------------------------------------------------
        public static string ReadOutlookSignature()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
            string signature = string.Empty;
            string sigfilename = GetSystemOption("EMAIL", "OutlookSignatureFile");
            DirectoryInfo diInfo = new DirectoryInfo(appDataDir);

            if (diInfo.Exists)
            {
                FileInfo[] fiSignature = diInfo.GetFiles(sigfilename); // Default Outlook Signature File

                if (fiSignature.Length > 0)
                {
                    StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
                    signature = sr.ReadToEnd();

                    if (!string.IsNullOrEmpty(signature))
                    {
                        string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
                        signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                    }
                }
            }
            return signature;
        }
        //---------------------------------------------------------------------------
        //  Return the current or next working day from a start date
        //  The Input Date is a DateTime the Output is a String as dd/MM/yyyy
        //  If the Input date is Sat or Sun or in the NWD Table it skips to the next 
        //  date and repeats the tests.
        //---------------------------------------------------------------------------
        public static string checkWD(DateTime lvInput)
        {
            using (var db = new DbContext) // CrmDB(NonWorkingDays);
            {
                bool lvAdd1Day;                                                             // Use a bool so it doesnt matter if Sat or Sun has been added to the table
                while (true)                                                                // Loop until next Working Day found
                {
                    lvAdd1Day = false;                                                      // Default flag value = unset
                    if (lvInput.DayOfWeek == DayOfWeek.Saturday) lvAdd1Day = true;          // Set Flag if Sat
                    if (lvInput.DayOfWeek == DayOfWeek.Sunday) lvAdd1Day = true;            // Set Flag if Sun
                                                                                            // Only test for NWD if not Sat or not Sun 
                    if (lvAdd1Day == false)                                                 // Two Ifs as if we use && then it always accesses the table
                        if (db.NonWorkingDays.Where(o => o.nwdDate == lvInput).Count() > 0) // See if Date is in the NWD Table
                            lvAdd1Day = true;                                               // Set flag if the date is in NWD Table
                    if (lvAdd1Day == false) break;                                          // Exit loop if flag says its a Working Day
                    lvInput = lvInput.AddDays(1);                                           // Next Date as current Date is Sat, Sun or NWD
                }
            }
            return (lvInput.ToShortDateString());
        }
        //---------------------------------------------------------------------------
        // Return Non-Working Dates from Today for a couple of years
        // Each date returned as a string seperated by a comma
        //---------------------------------------------------------------------------
        public static String getNextNWDs()
        {
            String NWDS = "";
            using (var db = new CRM_MVC())
            {
                var nwdsa = db.NonWorkingDays.Where(o => o.nwdDate >= DateTime.Today && o.nwdDate.Year <= DateTime.Today.Year + 2);
                foreach (var m in nwdsa)
                {
                    NWDS = NWDS + (NWDS == "" || NWDS == null ? m.nwdDate.ToString() : "," + m.nwdDate.ToString());
                }
            }
            return (NWDS);

        }
        //---------------------------------------------------------------------------
        // Check if the current user has permission to run a System Activity
        // Original version used tables
        // UserTable            User list
        // AuthFunctions        Functions list
        // AuthUserRoles        User Roles list
        // AuthRolesFunctions   Functions linked to Roles
        // AuthRoles            Roles list
        // This version uses the list produced by StoreUserFunctions()
        // Return True to allow the user to use the Function or False to forbid the user from using the function
        // Note that DomesticOnly forces the user into this menu and should be used via proper function authorisation
        //---------------------------------------------------------------------------
        public static bool CheckUser(string FunctionName)
        {
            if (GetSystemOption("MENU", "*ALL*").StartsWith("Y"))                // bypass Authorisation security and let everyone have everything 
                                                                                 //if (FunctionName == "DomesticOnly") { return false; } else { return true; }
                if (GetSystemOption("MENU", "*ALL*").StartsWith("N")) return false; // bypass Authorisation security so no one has access to anything 

            // Implement normal Function Authorisation if MENU *ALL* is empty
            int i = 0, granted = 1;
            while ((CRM_MVC.MvcApplication.Config.FuncNameList[i] != FunctionName) && (CRM_MVC.MvcApplication.Config.FuncNameList[i] != null) && (i < 256))
            {
                i++;
            }
            //get the list again so that if it fails a second time it is a genuine error and not a timeout
            if (CRM_MVC.MvcApplication.Config.FuncNameList[i] != FunctionName)
            {
                Services.SF.StoreUserFunctions();   // Retrive the list
                i = 0;
                while ((CRM_MVC.MvcApplication.Config.FuncNameList[i] != FunctionName) && (CRM_MVC.MvcApplication.Config.FuncNameList[i] != null) && (i < 256))
                {
                    i++;
                }
            }
            if (CRM_MVC.MvcApplication.Config.FuncNameList[i] != FunctionName) { granted = 0; }
            return (granted > 0);
        }
        //---------------------------------------------------------------------------
        // Find Out which Functions the user has access to and store them for 
        // HasPermission and CheckUser() If the user is not Active nothing is stored
        // which means that they cant access anything.
        // Global.asax starts too soon for UserOnly so it needs to be higher up
        // Currently using Home/Index Controller
        //---------------------------------------------------------------------------
        public static void StoreUserFunctions()
        {
            using (var db = new CRM_MVC.Models.UserTableDBContext())
            {
                string username = UserOnly();               // Global.asax starts too soon for UserOnly 
                FuncTable ft = new FuncTable();
                for (int j = 0; j < 256; j++) { CRM_MVC.MvcApplication.Config.FuncNameList[j] = null; }       // Clear out the array

                int i = 0;
                var uid = db.UserTables.Where(m => m.LoginName == username && m.UserActive == true).FirstOrDefault();
                if (uid == null) return;    // Exit if no Active User
                foreach (var aur in db.AuthUsersRoles.Where(m => m.UserID == uid.UserID))
                {
                    var ar = db.AuthRoles.Where(m => m.RoleID == aur.RoleID).FirstOrDefault();
                    if (ar.RoleActive == false) continue;
                    // 03/12/18 Include AuthRolesFunctions as a separate Context to avoid the error: The context cannot be used while the model is being created.
                    using (var dbx = new CrmDB())
                    {
                        foreach (var arf in dbx.AuthRolesFunctions.Where(m => m.RoleID == aur.RoleID))
                        {
                            Func f = new Func();
                            f = ft.Where(m => m.FunctionID == arf.FunctionID && m.FunctionActive == true).FirstOrDefault();
                            if (f != null)
                            {
                                CRM_MVC.MvcApplication.Config.FuncNameList[i] = f.FunctionName;     // Add to Global Security Function List
                                i++;
                            }
                        }
                    }
                }
            }
            //db.Dispose();           // Discard db so it can be forced to reread the db 
            //int adb = new CrmDB();
            //---------------------------------------------------------------------------
            // Return SystemOption SystemDesc from the Class and Code
            // 29/11/2018 Changed to make use of 'using' to try and avoid the error:
            // The Operation Cannot be Completed because the DBContext has been disposed 
            // which only seems to occur in the Production environment
            //---------------------------------------------------------------------------
            string GetSystemOption(string ipClass = null, string ipCode = null, string ipField = "V")
            {
                string retn = "";
                var so;
                using (var dbso = new CRM_MVC.Models.DbContext())
                {

                    //SystemOption so = db.SystemOptions.Where(m => m.SystemClass == ipClass && m.SystemCode == ipCode && m.SystemActive == true).FirstOrDefault();

                    //SystemOption so;

                    so = db.SystemOptions.Where(m => m.SystemClass == ipClass && m.SystemCode == ipCode && m.SystemActive == true).FirstOrDefault();
                }
                if (so != null)
                {
                    if (ipField == "D")
                        retn = so.SystemDesc;
                    else
                        retn = so.SystemValue;
                }
                return (retn);
            }
            //---------------------------------------------------------------------------
            // Code or uncode string (usually a password) so its not obvious 
            // ipCode True = Encode, False = Decode
            // Currently uses Base64
            //---------------------------------------------------------------------------
            public static string CodeString(string ipString = null, bool ipCode = true)
            {
                string opString = ipString;
                if (ipCode) opString = Encrypt(ipString); else opString = Decrypt(ipString);
                return opString;
            }
            //---------------------------------------------------------------------------
            // Return an encrypted string from a plain string
            //---------------------------------------------------------------------------
            public static string Encrypt(string str)
            {
                string EncrptKey = "2013;[pnuLIT)WebCodeExpert";
                byte[] byKey = { };
                byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
                byKey = System.Text.Encoding.UTF8.GetBytes(EncrptKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(str);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            //---------------------------------------------------------------------------
            // Return a plain string from a previously encrypted string
            //---------------------------------------------------------------------------
            public static string Decrypt(string str)
            {
                if (str == null) return null;       // Empty string
                str = str.Replace(" ", "+");
                string DecryptKey = "2013;[pnuLIT)WebCodeExpert";
                byte[] byKey = { };
                byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };
                byte[] inputByteArray = new byte[str.Length];

                byKey = System.Text.Encoding.UTF8.GetBytes(DecryptKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(str.Replace(" ", "+"));
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                try
                {
                    cs.FlushFinalBlock();
                }
                catch (Exception err)
                {
                    return str.Replace("+", " ");
                }
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }

        }

    }
}