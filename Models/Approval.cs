using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Approval
    {
        public Approval()
        {
            EmployeeApproval = new HashSet<EmployeeApproval>();
            PlanningUnitApproval = new HashSet<PlanningUnitApproval>();
        }

        public int ApprovalId { get; set; }
        public string Authority { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<EmployeeApproval> EmployeeApproval { get; set; }
        public virtual ICollection<PlanningUnitApproval> PlanningUnitApproval { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
