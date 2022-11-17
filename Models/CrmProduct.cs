using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long ProductID { get; set; }
        public virtual string ProductSupplier { get; set; }
        public virtual string ProductGroup { get; set; }
        public virtual string ProductType { get; set; }
        public virtual string ProductDesc { get; set; }
        public virtual string ProductAlt { get; set; }
        public virtual string ProductNotes { get; set; }
        public virtual string DescURL { get; set; }
        public virtual string DescFile { get; set; }
        public virtual string CompURL { get; set; }
        public virtual string CompFile { get; set; }
        public virtual bool WarehouseFlag { get; set; }
        public virtual bool SalesFlag { get; set; }
        public virtual DateTime? InactiveDate { get; set; }
        public virtual string StockStatus { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class ProductDBContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
    }
}
