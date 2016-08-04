using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingPrognosisParameter
    {
        public int AirportStaffingPrognosisParameterId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public int AirportTerminalConfigurationId { get; set; }
        public int? AirportCheckpointConfigurationId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? DayTypeId { get; set; }
        public int? QualificationId { get; set; }
        public int Type { get; set; }
        public decimal Value { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual AirportCheckpointConfiguration AirportCheckpointConfiguration { get; set; }
        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual AirportTerminalConfiguration AirportTerminalConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
