using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingDataScheduleRow
    {
        public int SchedulingDataScheduleRowId { get; set; }
        public int SchedulingDataVersionId { get; set; }
        public int PlanningUnitId { get; set; }
        public int? SchedulingDataShiftId { get; set; }
        public int WeekNumber { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
        public virtual SchedulingDataShift SchedulingDataShift { get; set; }
        public virtual SchedulingDataVersion SchedulingDataVersion { get; set; }
    }
}
