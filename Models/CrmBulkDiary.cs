using System;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BulkDiary
    {
        public string DiaryCode { get; set; }
        public string DiaryUser { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DiariesPerDay { get; set; }
        public bool SkipWeekEnd { get; set; }
        public bool PostBack { get; set; }
    }
    public class BulkDiaryDBContext : DbContext
    {
        public virtual DbSet<BulkDiary> BulkDiarys { get; set; }
    }
}
