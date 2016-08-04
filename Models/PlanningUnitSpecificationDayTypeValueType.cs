using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitSpecificationDayTypeValueType
    {
        public PlanningUnitSpecificationDayTypeValueType()
        {
            PlanningUnitSpecificationDayTypeValue = new HashSet<PlanningUnitSpecificationDayTypeValue>();
        }

        public int PlanningUnitSpecificationDayTypeValueTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PlanningUnitSpecificationDayTypeValue> PlanningUnitSpecificationDayTypeValue { get; set; }
    }
}
