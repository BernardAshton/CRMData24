using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class ProductSupplier
    {
        [Key]
        public virtual int ProductSupplierID { get; set; }
        public virtual string Supplier { get; set; }
    }
    public class ProductupplierDBContext : DbContext
    {
        public virtual DbSet<ProductSupplier> Productuppliers { get; set; }
    }
}
