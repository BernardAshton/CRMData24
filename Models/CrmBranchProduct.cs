using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchProduct
    {
        [Key]
        public virtual int BranchProductID { get; set; }
        public virtual int BranchID { get; set; }
        public virtual long ProductID { get; set; }
        public virtual string Supplier { get; set; }
        public virtual string Group { get; set; }
        public virtual string Type { get; set; }
        public virtual string Alt { get; set; }
        public virtual string Desc { get; set; }
        public virtual string Reason { get; set; }
        public virtual decimal ProductPrice { get; set; }
        public virtual int MinOrderQty { get; set; }
        public virtual int OrderQty { get; set; }
        public virtual int MonthlySales { get; set; }
        public virtual int StockLevel { get; set; }
        public virtual int DaysOfStock { get; set; }
        public virtual DateTime OutOfStock { get; set; }
        public virtual string Notes { get; set; }
        public virtual bool ProductActive { get; set; }
        public virtual bool PostBack { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
        public Branch branch { get; set; }
        public Product product { get; set; }
    }
    public class BranchProductDBContext : DbContext
    {
        public virtual DbSet<BranchProduct> BranchProducts { get; set; }
    }
}
