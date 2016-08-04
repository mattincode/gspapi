using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingDataShift
    {
        public SchedulingDataShift()
        {
            SchedulingDataScheduleRow = new HashSet<SchedulingDataScheduleRow>();
        }

        public int SchedulingDataShiftId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string BreakXml { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<SchedulingDataScheduleRow> SchedulingDataScheduleRow { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
