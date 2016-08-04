using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Union
    {
        public Union()
        {
            EmployeeUnionTrustee = new HashSet<EmployeeUnionTrustee>();
            WorkContract = new HashSet<WorkContract>();
        }

        public int UnionId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<EmployeeUnionTrustee> EmployeeUnionTrustee { get; set; }
        public virtual ICollection<WorkContract> WorkContract { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
    }
}
