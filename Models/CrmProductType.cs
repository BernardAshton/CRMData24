using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class ProductType
    {
        [Key]
        public virtual int ProductTypeID { get; set; }
        public virtual string Type { get; set; }
        public virtual bool WarehouseFlag { get; set; }
    }
    public class ProductTypeDBContext : DbContext
    {
        public virtual DbSet<ProductType> ProductTypes { get; set; }
    }
}
