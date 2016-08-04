using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class DaytypeRulePlanningUnitShift
    {
        public int DayTypeRuleId { get; set; }
        public int PlanningUnitShiftId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual DayTypeRule DayTypeRule { get; set; }
        public virtual PlanningUnitShift PlanningUnitShift { get; set; }
    }
}
