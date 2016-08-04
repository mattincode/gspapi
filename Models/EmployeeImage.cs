using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EmployeeImage
    {
        public int EmployeeImageId { get; set; }
        public int EmployeeId { get; set; }
        public byte[] EmployeeImage1 { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
