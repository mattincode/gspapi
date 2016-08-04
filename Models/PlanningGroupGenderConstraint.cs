using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningGroupGenderConstraint
    {
        public int PlanningGroupGenderConstraintId { get; set; }
        public int PlanningGroupId { get; set; }
        public int Key { get; set; }
        public int QualificationId { get; set; }
        public int? MinNoOfMen { get; set; }
        public int? MinNoOfWomen { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningGroup PlanningGroup { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
