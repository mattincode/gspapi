using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class JobLogItem
    {
        public int JobLogItemId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string RuleName { get; set; }
        public int? JobRunId { get; set; }
        public int? ProfitCenterId { get; set; }
        public int? EmployeeId { get; set; }
        public int? PlanningUnitId { get; set; }
        public int? BookingChangeTraceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public string ShortNotes { get; set; }
        public bool Handled { get; set; }
        public int? CrudType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
