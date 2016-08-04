using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningGroupType
    {
        public PlanningGroupType()
        {
            PlanningGroup = new HashSet<PlanningGroup>();
        }

        public int PlanningGroupTypeId { get; set; }
        public string Description { get; set; }
        public byte TypeOfPlanningGroup { get; set; }

        public virtual ICollection<PlanningGroup> PlanningGroup { get; set; }
    }
}
