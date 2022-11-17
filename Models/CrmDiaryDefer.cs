using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CRM_MVC.Models
{
   public class DiaryDefer
    {
        [Key]
        public virtual string DeferCode { get; set; }
        public virtual string DeferReason { get; set; }
        public virtual int DeferMins { get; set; }
        public virtual int DeferHours { get; set; }
        public virtual int DeferDays { get; set; }
    }
    public class DiaryDeferDBContext : DbContext
    {
        public virtual DbSet<DiaryDefer> BranchDiaryDefers { get; set; }
    }
}