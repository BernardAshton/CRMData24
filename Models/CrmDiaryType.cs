using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class DiaryType
    {
        [Key]
        public virtual string DiaryTypeCode { get; set; }
        public virtual string DiaryTypeDesc { get; set; }
        public virtual Boolean DiaryTypeSystem { get; set; }
        public virtual Boolean DiaryTypeAmend { get; set; }
    }
    public class DiaryTypeDBContext : DbContext
    {
        public virtual DbSet<DiaryType> DiaryTypes { get; set; }
    }
}
