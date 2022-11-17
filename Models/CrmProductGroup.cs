using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class ProductGroup
    {
        [Key]
        public virtual int ProductGroupID { get; set; }
        public virtual string Group { get; set; }
    }
    public class ProductGroupDBContext : DbContext
    {
        public virtual DbSet<ProductGroup> ProductGroups { get; set; }
    }
}
