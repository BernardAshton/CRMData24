using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class OrgContact
    {
        [Key]
        public virtual int OrgContactID { get; set; }
        public virtual int OrgOfficeID { get; set; }
        public virtual int OrgID { get; set; }
        public virtual string ContactName { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string DirectTel { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Email { get; set; }
        public virtual string ContactNote { get; set; }
        public virtual bool OrgOfficeCorresp { get; set; }
        public virtual bool Left { get; set; }
        public virtual bool FromSage { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class OrgContactDBContext : DbContext
    {
        public virtual DbSet<OrgContact> OrgContacts { get; set; }
    }
}
