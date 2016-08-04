using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingPlanningUnitParameter
    {
        public int AirportStaffingPlanningUnitParameterId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public int Parameter { get; set; }
        public decimal OrgValue { get; set; }
        public decimal NewValue { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual AirportPlanningUnitParameterConfiguration ParameterNavigation { get; set; }
    }
}
