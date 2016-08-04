using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitApproval
    {
        public int PlanningUnitApprovalId { get; set; }
        public int PlanningUnitId { get; set; }
        public int ApprovalId { get; set; }
        public int BookingSeverity { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Approval Approval { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
    }
}
