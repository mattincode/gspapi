using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportConfiguration
    {
        public AirportConfiguration()
        {
            AirportConfigurationEmployee = new HashSet<AirportConfigurationEmployee>();
            AirportStaffingPrognosis = new HashSet<AirportStaffingPrognosis>();
            AirportTerminalConfiguration = new HashSet<AirportTerminalConfiguration>();
        }

        public int AirportConfigurationId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportConfigurationEmployee> AirportConfigurationEmployee { get; set; }
        public virtual ICollection<AirportStaffingPrognosis> AirportStaffingPrognosis { get; set; }
        public virtual ICollection<AirportTerminalConfiguration> AirportTerminalConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
