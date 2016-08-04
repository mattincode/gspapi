using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class DayType
    {
        public DayType()
        {
            DaytypePlanningUnitShift = new HashSet<DaytypePlanningUnitShift>();
            FictiveSchedulingShift = new HashSet<FictiveSchedulingShift>();
            PlanningUnitSpecificationDayType = new HashSet<PlanningUnitSpecificationDayType>();
        }

        public int DayTypeId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int Importance { get; set; }

        public virtual ICollection<DaytypePlanningUnitShift> DaytypePlanningUnitShift { get; set; }
        public virtual ICollection<FictiveSchedulingShift> FictiveSchedulingShift { get; set; }
        public virtual ICollection<PlanningUnitSpecificationDayType> PlanningUnitSpecificationDayType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
