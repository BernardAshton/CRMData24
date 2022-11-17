using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class ProductOmit
    {
        [Key]
        public virtual string ProductType { get; set; }
        public virtual string ProductOmitNote { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class ProductOmitDBContext : DbContext
    {
        public virtual DbSet<ProductOmit> ProductOmits { get; set; }
    }
}
