using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingDataCycleRow
    {
        public int SchedulingDataCycleRowId { get; set; }
        public int SchedulingDataCycleId { get; set; }
        public int RowNumber { get; set; }
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
        public virtual SchedulingDataCycle SchedulingDataCycle { get; set; }
    }
}
