using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class LastBranch
    {
        public string SageBranch { get; set; }
        public string CRMBranch { get; set; }
    }
    public class DbContext
    {
        public virtual DbSet<LastBranch> LastBranches { get; set; }
    }
}
