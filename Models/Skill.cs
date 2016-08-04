using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Skill
    {
        public Skill()
        {
            EmployeeSkill = new HashSet<EmployeeSkill>();
            PlanningUnitSkill = new HashSet<PlanningUnitSkill>();
        }

        public int SkillId { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkill { get; set; }
        public virtual ICollection<PlanningUnitSkill> PlanningUnitSkill { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
