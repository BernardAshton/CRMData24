using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class PromoDetail
    {
        [Key]
        public virtual int PromoID { get; set; }
        public virtual string PromoName { get; set; }
        public virtual string PromoDetails { get; set; }
        public virtual DateTime PromoStart { get; set; }
        public virtual DateTime PromoEnd { get; set; }
        public virtual string PromoURL { get; set; }
        public virtual string PromoPDF { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class PromoDetailDBContext : DbContext
    {
        public virtual DbSet<PromoDetail> PromoDetails { get; set; }
    }
}
