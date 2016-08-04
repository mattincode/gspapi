using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class VacancyCode
    {
        public VacancyCode()
        {
            PlanningUnitShift = new HashSet<PlanningUnitShift>();
        }

        public int VacancyCodeId { get; set; }
        public bool PlanningUnitDependency { get; set; }
        public bool EmployeeDependency { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<PlanningUnitShift> PlanningUnitShift { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
