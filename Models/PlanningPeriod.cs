using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningPeriod
    {
        public PlanningPeriod()
        {
            WorkScheduleChangeSet = new HashSet<WorkScheduleChangeSet>();
        }

        public int PlanningPeriodId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public short PeriodLength { get; set; }
        public byte TimePeriodType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<WorkScheduleChangeSet> WorkScheduleChangeSet { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
