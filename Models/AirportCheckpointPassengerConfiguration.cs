using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportCheckpointPassengerConfiguration
    {
        public AirportCheckpointPassengerConfiguration()
        {
            AirportCheckpointStaffConfiguration = new HashSet<AirportCheckpointStaffConfiguration>();
        }

        public int AirportCheckpointPassengerConfigurationId { get; set; }
        public int AirportCheckpointConfigurationId { get; set; }
        public int PassengerCountPerHour { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportCheckpointStaffConfiguration> AirportCheckpointStaffConfiguration { get; set; }
        public virtual AirportCheckpointConfiguration AirportCheckpointConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
