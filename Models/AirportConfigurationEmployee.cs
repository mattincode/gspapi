using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportConfigurationEmployee
    {
        public int AirportConfigurationEmployeeId { get; set; }
        public int AirportConfigurationId { get; set; }
        public int EmployeeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AirportConfiguration AirportConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
