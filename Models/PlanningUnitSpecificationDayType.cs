using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitSpecificationDayType
    {
        public PlanningUnitSpecificationDayType()
        {
            PlanningUnitSpecificationDayTypeValue = new HashSet<PlanningUnitSpecificationDayTypeValue>();
        }

        public int PlanningUnitSpecificationDayTypeId { get; set; }
        public int PlanningUnitVersionId { get; set; }
        public int DayTypeId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<PlanningUnitSpecificationDayTypeValue> PlanningUnitSpecificationDayTypeValue { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual DayType DayType { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnitVersion PlanningUnitVersion { get; set; }
    }
}
