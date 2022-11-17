using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class OrgOffice
    {
        [Key]
        public virtual int OrgOfficeID { get; set; }
        public virtual long CustDeliveryAddressID { get; set; }
        public virtual int OrgID { get; set; }
        public virtual string OrgType { get; set; }
        public virtual string OfficeName { get; set; }
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string AddressLine3 { get; set; }
        public virtual string AddressLine4 { get; set; }
        public virtual string PostCode { get; set; }
        public virtual string City { get; set; }
        public virtual string County { get; set; }
        public virtual string Country { get; set; }
        public virtual string MainTel { get; set; }
        public virtual string OfficeEmail { get; set; }
        public virtual string OrgNote { get; set; }
        public virtual int BranchID { get; set; }
        public virtual bool Closed { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public virtual string UpdateUser { get; set; }
    }
    public class OrgOfficeDBContext : DbContext
    {
        public virtual DbSet<OrgOffice> OrgOffices { get; set; }
    }
}
