using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitShiftBreak
    {
        public int PlanningUnitShiftBreakId { get; set; }
        public int PlanningUnitShiftId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnitShift PlanningUnitShift { get; set; }
    }
}
