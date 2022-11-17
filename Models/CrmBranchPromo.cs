using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchPromo
    {
        [Key]
        public virtual int BranchPromoID { get; set; }
        public virtual int BranchID { get; set; }
        public virtual int PromoID { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class BranchPromoDBContext : DbContext
    {
        public virtual DbSet<BranchPromo> BranchPromos { get; set; }
    }
}
