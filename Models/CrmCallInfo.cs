using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class CallInfo
    {
        [Key]
        public virtual int CallInfoID { get; set; }
        public virtual string CallNo1 { get; set; }
        public virtual string CallNo2 { get; set; }
        public virtual string CallDir { get; set; }
        public virtual int CallRing { get; set; }
        public virtual DateTime CallDate { get; set; }
        public virtual int CallDur { get; set; }
        public virtual string CallExt { get; set; }
        public virtual string CallPort { get; set; }
        public virtual Decimal CallCost { get; set; }
        public virtual int BranchID { get; set; }
        public virtual string FileIn { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class CallInfoDBContext : DbContext
    {
        public virtual DbSet<CallInfo> CallInfos { get; set; }
    }
}
