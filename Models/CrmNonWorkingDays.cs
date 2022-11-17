using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class NonWorkingDays
    {
        [Key]
        public virtual int nwdID { get; set; }
        public virtual DateTime nwdDate { get; set; }
        public virtual string nwdDesc { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class NonWorkingDaysDBContext : DbContext
    {
        public virtual DbSet<NonWorkingDays> NonWorkingDays{ get; set; }
    }
}
