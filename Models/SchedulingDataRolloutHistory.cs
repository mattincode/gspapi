using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingDataRolloutHistory
    {
        public int SchedulingDataRolloutHistoryId { get; set; }
        public int SchedulingDataId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime EmployeeDateFrom { get; set; }
        public DateTime EmployeeDateTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual SchedulingData SchedulingData { get; set; }
    }
}
