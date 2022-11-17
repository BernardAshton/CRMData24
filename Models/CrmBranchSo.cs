using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchSo
    {
        [Key]
        public virtual int BranchSOID {get; set;}
        public virtual int BranchID	{get; set;}
        public virtual string SOCode { get; set; }
        public virtual string SOName { get; set; }
        public virtual string CustomerID { get; set; }
        public virtual DateTime SODate { get; set; }
        public virtual string CalmagCode { get; set; }
        public virtual string CalmagDesc { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual string ProductDesc { get; set; }
        public virtual int ProductQty { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual string OtherProductDetails { get; set; }
        public virtual string SalesAreaCode { get; set; }
        public virtual string OtherSalesAreaDetails { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpDateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class BranchSoDBContext : DbContext
    {
        public virtual DbSet<BranchSo> BranchSoes { get; set; }
    }
}
