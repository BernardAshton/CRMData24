using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class CommProduct
    {
        [Key]
        public virtual int CommProdID { get; set; }
        public virtual string ProdGroup { get; set; }
        public virtual string ProdType { get; set; }
        public virtual string ProdModel { get; set; }
        public virtual string ProdDesc { get; set; }
        public virtual decimal ListPrice { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class CommProductDBContext : DbContext
    {
        public virtual DbSet<CommProduct> CommProducts { get; set; }
    }
}
