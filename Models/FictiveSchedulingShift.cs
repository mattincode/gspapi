using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class FictiveSchedulingShift
    {
        public int FictiveSchedulingShiftId { get; set; }
        public int? FictiveSchedulingDataId { get; set; }
        public int? DayTypeId { get; set; }
        public int WeekNumber { get; set; }
        public int? FictiveSchedulingShiftTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual DayType DayType { get; set; }
        public virtual FictiveSchedulingData FictiveSchedulingData { get; set; }
        public virtual FictiveSchedulingShiftType FictiveSchedulingShiftType { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
