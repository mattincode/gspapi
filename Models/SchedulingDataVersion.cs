using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingDataVersion
    {
        public SchedulingDataVersion()
        {
            SchedulingDataScheduleRow = new HashSet<SchedulingDataScheduleRow>();
            SchedulingDataVersionEmployee = new HashSet<SchedulingDataVersionEmployee>();
        }

        public int SchedulingDataVersionId { get; set; }
        public int SchedulingDataId { get; set; }
        public int NumberOfWeeks { get; set; }
        public int StartingWeek { get; set; }
        public DateTime? RollOutStartDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<SchedulingDataScheduleRow> SchedulingDataScheduleRow { get; set; }
        public virtual ICollection<SchedulingDataVersionEmployee> SchedulingDataVersionEmployee { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual SchedulingData SchedulingData { get; set; }
    }
}
