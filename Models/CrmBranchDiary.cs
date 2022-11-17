using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchDiary
    {
        [Key]
        public virtual int DiaryID { get; set; }
        public virtual int BranchID { get; set; }
        public virtual long BranchProductID { get; set; }
        public virtual bool AccountManagement { get; set; }
        public virtual string DiaryTypeCode { get; set; }
        public virtual string DiaryUser { get; set; }
        public virtual string DiaryNote { get; set; }
        public virtual int DiaryValue { get; set; }
        public virtual DateTime DiaryRemindDate { get; set; }
        public virtual string RemindDefer { get; set; }
        public virtual DateTime? DiaryCloseDate { get; set; }  // Nullable CloseDate
        public virtual string DiaryCloseCode { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
        public Branch branch { get; set; }
    }
    public class BranchDiaryDBContext : DbContext
    {
        public virtual DbSet<BranchDiary> BranchDiarys { get; set; }
    }
}


