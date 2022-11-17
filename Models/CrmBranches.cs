using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class Branch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual int BranchID { get; set; }
        public virtual string CustomerID { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual string BranchDesc { get; set; }
        public virtual string BranchName { get; set; }
        public virtual string BranchAddressLine1 { get; set; }
        public virtual string BranchAddressLine2 { get; set; }
        public virtual string BranchAddressLine3 { get; set; }
        public virtual string BranchAddressLine4 { get; set; }
        public virtual string BranchCity { get; set; }
        public virtual string BranchCounty { get; set; }
        public virtual string BranchPostCode { get; set; }
        public virtual string BranchContact { get; set; }
        public virtual string BranchTelNo { get; set; }
        public virtual string BranchFaxNo { get; set; }
        public virtual string BranchEmail { get; set; }
        public virtual string TaxCode { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string SOCode { get; set; }
        public virtual string WebSite { get; set; }
        public virtual string BranchDomesticBDM { get; set; }
        public virtual string UserDBDM { get; set; }
        public virtual string BranchCommercialBDM { get; set; }
        public virtual string UserCBDM { get; set; }
        public virtual int CreditLimit { get; set; }
        public virtual string CreditPosition { get; set; }
        public virtual int Balance { get; set; }
        public virtual bool OnHold { get; set; }
        public virtual int TimeToPay { get; set; }
        public virtual DateTime? TimeToPayDate { get; set; }
        public virtual string CreditMemo { get; set; }
        public virtual int SalesYTD { get; set; }
        public virtual int SalesYTDLast { get; set; }
        public virtual int SalesYTDPrev { get; set; }
        public virtual int BudgetYTD { get; set; }
        public virtual int CustomerForecast { get; set; }
        public virtual int SalesYTDpc { get; set; }
        public virtual string BranchNotes { get; set; }
        public virtual string SalesStrategy { get; set; }
        public virtual string PriceBook { get; set; }
        public virtual bool Commercial { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
        public virtual List<BranchProduct> branchproducts { get; set; }
        public virtual List<BranchDiary> branchdiaries { get; set; }
    }
    public class BranchesDBContext : DbContext
    {
        public virtual DbSet<Branch> Branches { get; set; }
    }
}