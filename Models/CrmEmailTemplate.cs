using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class EmailTemplate
    {
        [Key]
        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual string Type { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Body { get; set; }
        public virtual bool Attachment { get; set; }
    }
    public class EmailTemplatDBContext : DbContext
    { 
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
    }
}
