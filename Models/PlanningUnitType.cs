using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitType
    {
        public PlanningUnitType()
        {
            PlanningUnit = new HashSet<PlanningUnit>();
            PlanningUnitDefinition = new HashSet<PlanningUnitDefinition>();
            PlanningUnitTypeSalarySupplement = new HashSet<PlanningUnitTypeSalarySupplement>();
        }

        public int PlanningUnitTypeId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool TimeReporting { get; set; }
        public bool IsWorkTime { get; set; }
        public bool DeductsFromOtherTime { get; set; }
        public bool AllowedOnPlannedSchedule { get; set; }
        public bool AllowLearningTime { get; set; }
        public bool DoubleBookingOnPlanningUnitAllowed { get; set; }
        public bool AllowOverlappingShifts { get; set; }

        public virtual ICollection<PlanningUnit> PlanningUnit { get; set; }
        public virtual ICollection<PlanningUnitDefinition> PlanningUnitDefinition { get; set; }
        public virtual ICollection<PlanningUnitTypeSalarySupplement> PlanningUnitTypeSalarySupplement { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
