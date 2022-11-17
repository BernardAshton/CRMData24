using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchEmail
    {
        [Key]
        public virtual int BranchEmailID { get; set; }
        public virtual int BranchID { get; set; }
        public virtual string EmailDir { get; set; }
        public virtual DateTime EmailDateTime { get; set; }
        public virtual string TemplateCode { get; set; }
        public virtual string EmailFrom { get; set; }
        public virtual string EmailTo { get; set; }
        public virtual string EmailCC { get; set; }
        public virtual string EmailSubject { get; set; }
        public virtual string EmailBody { get; set; }
        public virtual string EmailAttachmentList { get; set; }
        public virtual string EmailAttachmentFiles { get; set; }
        public virtual string EmailNote { get; set; }
        public virtual bool PostBack { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
        public Branch branch { get; set; }
        public EmailTemplate emailtemplate { get; set; }
    }
    public class BranchEmailDBContext : DbContext
    {
        public virtual DbSet<BranchEmail> BranchEmails { get; set; }
    }
}
