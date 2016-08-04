using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportCheckpointConfiguration
    {
        public AirportCheckpointConfiguration()
        {
            AirportCheckpointPassengerConfiguration = new HashSet<AirportCheckpointPassengerConfiguration>();
            AirportStaffingPrognosisParameter = new HashSet<AirportStaffingPrognosisParameter>();
        }

        public int AirportCheckpointConfigurationId { get; set; }
        public int AirportTerminalConfigurationId { get; set; }
        public int MinimumNumberOfMen { get; set; }
        public int MinimumNumberOfWomen { get; set; }
        public string Name { get; set; }
        public int? PlanningGroupId { get; set; }
        public int CheckpointTypeId { get; set; }
        public int? DependsOnCheckpointId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportCheckpointPassengerConfiguration> AirportCheckpointPassengerConfiguration { get; set; }
        public virtual ICollection<AirportStaffingPrognosisParameter> AirportStaffingPrognosisParameter { get; set; }
        public virtual AirportCheckpointConfiguration AirportCheckpointConfigurationNavigation { get; set; }
        public virtual AirportCheckpointConfiguration InverseAirportCheckpointConfigurationNavigation { get; set; }
        public virtual AirportTerminalConfiguration AirportTerminalConfiguration { get; set; }
        public virtual AirportCheckpointType CheckpointType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningGroup PlanningGroup { get; set; }
    }
}
