using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchPhoneCall
    {
        [Key]
        public virtual int BranchPhoneID { get; set; }
        public virtual int BranchID { get; set; }
        public virtual string PhoneDir { get; set; }            // Direction In or Out
        public virtual string PhoneTemplate { get; set; }
        public virtual DateTime PhoneDateTime { get; set; }
        public virtual string PhoneFrom { get; set; }
        public virtual string PhoneTo { get; set; }
        public virtual decimal PhoneDuration { get; set; }
        public virtual string PhoneContact { get; set; }
        public virtual string PhoneSubject { get; set; }
        public virtual string PhoneNote { get; set; }
        public virtual string PhoneSource { get; set; }
        public virtual bool PostBack { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
        public Branch branch { get; set; }
    }
    public class BranchPhoneCallDBContext : DbContext
    {
        public virtual DbSet<BranchDiary> BranchDiarys { get; set; }
    }
}
    