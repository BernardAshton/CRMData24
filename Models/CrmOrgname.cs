using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class OrgName
    {
        [Key]
        public virtual int OrgID { get; set; }
        public virtual long SLCustomerAccountID { get; set; }
        public virtual string Name { get; set; }
        public virtual string OrgNameNote { get; set; }
        public virtual string OrgWebSite { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class OrgNameDBContext : DbContext
    {
        public virtual DbSet<OrgName> OrgNames { get; set; }
    }
}
