using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class DiaryClose
    {
        [Key]
        public virtual string DiaryCloseCode { get; set; }
        public virtual string DiaryCloseDesc { get; set; }
    }

    public class DiaryCloseDBContext : DbContext
    {
        public virtual DbSet<DiaryClose> DiaryCloses { get; set; }
    }
}