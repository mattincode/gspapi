using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportPlanningUnitParameterConfiguration
    {
        public AirportPlanningUnitParameterConfiguration()
        {
            AirportStaffingPlanningUnitParameter = new HashSet<AirportStaffingPlanningUnitParameter>();
        }

        public int AirportPlanningUnitParameterConfigurationId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Type { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportStaffingPlanningUnitParameter> AirportStaffingPlanningUnitParameter { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
