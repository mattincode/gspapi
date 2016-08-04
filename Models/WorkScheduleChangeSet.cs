using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class WorkScheduleChangeSet
    {
        public int WorkScheduleChangeSetId { get; set; }
        public int PlanningPeriodId { get; set; }
        public DateTime PeriodStartDate { get; set; }
        public int ChangeSetTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual PlanningPeriod PlanningPeriod { get; set; }
    }
}
