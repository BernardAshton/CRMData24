using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class ProductSerialNo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]      // Use the record key from Sage
        public virtual int TraceableTransHistoryID { get; set; }
        public virtual string SerialNo { get; set; }
        public virtual string ProductCode { get; set; }
        public virtual int BranchID { get; set; }
        public virtual string CustomerID { get; set; }
        public virtual string CustomerName { get; set; }
        public virtual string SageOrderNo { get; set; }
        public virtual DateTime SageOrderDate { get; set; }
    }
    public class ProductSerialNoDBContext : DbContext
    {
        public virtual DbSet<ProductSerialNo> ProductSerialNos { get; set; }
    }
}
