using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class CodeDisplay
    {
        public long CodeValue { get; set; }
        public string CodeText { get; set; }
    }
    public class CodeisplayDBContext : DbContext
    {
        public virtual DbSet<CodeDisplay> CodeDisplays { get; set; }
    }
}
