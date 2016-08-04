using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportCheckpointStaffConfiguration
    {
        public int AirportCheckpointStaffConfigurationId { get; set; }
        public int AirportCheckpointPassengerConfigurationId { get; set; }
        public int QualificationId { get; set; }
        public int Count { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AirportCheckpointPassengerConfiguration AirportCheckpointPassengerConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
