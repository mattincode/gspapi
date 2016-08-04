using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitQualification
    {
        public int PlanningUnitQualificationId { get; set; }
        public int PlanningUnitId { get; set; }
        public int QualificationId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
