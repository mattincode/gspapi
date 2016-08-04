using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class FictiveSchedulingShiftTypeHour
    {
        public int FictiveSchedulingShiftTypeHourId { get; set; }
        public int ProfitCenterId { get; set; }
        public int FictiveSchedulingShiftTypeId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual FictiveSchedulingShiftType FictiveSchedulingShiftType { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
