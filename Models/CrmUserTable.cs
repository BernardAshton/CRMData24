using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class UserTable
    {
        [Key]
        public virtual int UserID { get; set; }
        public virtual string LoginName { get; set; }
        public virtual string UserDescription { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string UserNote { get; set; }
        public virtual bool UserActive { get; set; }
        public virtual string UserRoles { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class UserTableDBContext : DbContext
    {
        public virtual DbSet<UserTable> UserTables { get; set; }
    }
}
