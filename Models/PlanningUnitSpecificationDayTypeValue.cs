using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitSpecificationDayTypeValue
    {
        public int PlanningUnitSpecificationDayTypeValueId { get; set; }
        public int PlanningUnitSpecificationDayTypeId { get; set; }
        public int PlanningUnitSpecificationDayTypeValueTypeId { get; set; }
        public int ValueId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public double? Amount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnitSpecificationDayType PlanningUnitSpecificationDayType { get; set; }
        public virtual PlanningUnitSpecificationDayTypeValueType PlanningUnitSpecificationDayTypeValueType { get; set; }
    }
}
