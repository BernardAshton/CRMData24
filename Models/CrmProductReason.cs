using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class ProductReason
    {
        [Key]
        public virtual int ProductReasonID { get; set; }
        public virtual string Reason { get; set; }
    }
    public class ProductReasonDBContext : DbContext
    {
        public virtual DbSet<ProductReason> ProductReasons { get; set; }
    }
}
