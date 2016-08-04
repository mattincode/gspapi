using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EventLog
    {
        public int EventLogId { get; set; }
        public int? ProfitCenterNumber { get; set; }
        public string PlanningUnitNumber { get; set; }
        public int? EmployeeNumber { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
