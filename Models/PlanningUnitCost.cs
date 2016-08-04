using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitCost
    {
        public int PlanningUnitCostId { get; set; }
        public int PlanningUnitId { get; set; }
        public string Text { get; set; }
        public double Cost { get; set; }
        public int PlanningUnitCostTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnitCostType PlanningUnitCostType { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
    }
}
