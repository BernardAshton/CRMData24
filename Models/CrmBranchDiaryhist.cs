using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchDiaryHist
    {
        [Key]
        public virtual int DiaryHistID {get; set;}
        public virtual int DiaryID {get; set;}
        public virtual int BranchID { get; set; }
        public virtual Int64 BranchProductID { get; set; }
        public virtual string RecType { get; set; }
        public virtual string RecSource { get; set; }
        public virtual string DiaryTypeCode { get; set; }
        public virtual string DiaryUser { get; set; }
        public virtual string DiaryNote { get; set; }
        public virtual int DiaryValue { get; set; }
        public virtual DateTime? DiaryRemindDate { get; set; }
        public virtual string DiaryReasonCode { get; set; }
        public virtual string DiaryCloseCode { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class BranchDiaryHistDBContext : DbContext
    {
        public virtual DbSet<BranchDiaryHist> BranchDiaryHistss { get; set; }
    }
}
