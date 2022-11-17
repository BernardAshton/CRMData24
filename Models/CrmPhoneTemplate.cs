using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class PhoneTemplate
    {
        [Key]
        public virtual string Code { get; set; }
        public virtual string Type { get; set; }
        public virtual string Description { get; set; }
        public virtual string PhoneDir { get; set; }
        public virtual string Subject { get; set; }
    }
    public class PhoneTemplateDBContext : DbContext
    {
        public virtual DbSet<PhoneTemplate> PhoneTemplates { get; set; }
    }
}
