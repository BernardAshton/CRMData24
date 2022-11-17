using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class SystemOption
    {
        [Key]
        public virtual int SystemOptionID { get; set; }
        [Required]
        public virtual string SystemClass { get; set; }
        [Required]
        public virtual string SystemCode { get; set; }
        [Required]
        public virtual string SystemDesc { get; set; }
        [Required]
        public virtual string SystemValue { get; set; }
        public virtual bool SystemActive { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class SystemOptionDBContext : DbContext
    {
        public virtual DbSet<SystemOption> SystemOptions { get; set; }
    }
}
