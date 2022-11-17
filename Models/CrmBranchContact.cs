using System;
using System.Web;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchContact
    {
        [Key]
        public virtual int BranchContactID { get; set; }
        public virtual int BranchID { get; set; }
        public virtual string ContactType { get; set; }
        public virtual string JobTitle { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [EmailAddress]
        public virtual string Email { get; set; }
        public virtual string WorkTel { get; set; }
        public virtual string MobileTel { get; set; }
        public virtual string HomeTel { get; set; }
        public virtual string ContactNote { get; set; }
        public virtual bool DNCFlag { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
        public Branch branch { get; set; }
    }
            public class BranchContactDBContext : DbContext
    {
        public virtual DbSet<BranchContact> BranchContacts { get; set; }
    }
}

