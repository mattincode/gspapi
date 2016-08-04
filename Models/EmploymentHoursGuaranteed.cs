using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EmploymentHoursGuaranteed
    {
        public int EmploymentHoursGuaranteedId { get; set; }
        public decimal HoursGuaranteed { get; set; }
        public int EmploymentId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employment Employment { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
