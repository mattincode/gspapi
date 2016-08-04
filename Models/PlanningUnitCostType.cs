using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitCostType
    {
        public PlanningUnitCostType()
        {
            PlanningUnitCost = new HashSet<PlanningUnitCost>();
        }

        public int PlanningUnitCostTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlanningUnitCost> PlanningUnitCost { get; set; }
    }
}
