using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingDataCycle
    {
        public SchedulingDataCycle()
        {
            SchedulingDataCycleRow = new HashSet<SchedulingDataCycleRow>();
        }

        public int SchedulingDataCycleId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<SchedulingDataCycleRow> SchedulingDataCycleRow { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
