using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class WorkContractParameter
    {
        public WorkContractParameter()
        {
            WorkContractRule = new HashSet<WorkContractRule>();
        }

        public int WorkContractParameterId { get; set; }
        public string Name { get; set; }
        public bool AllowChangeOnProfitcenter { get; set; }
        public bool AllowChangeOnPlanningUnit { get; set; }
        public bool AllowChangeOnEmployee { get; set; }
        public int InputValueAccumulation { get; set; }
        public int InputPeriodMethod { get; set; }
        public int? ParameterGroupId { get; set; }

        public virtual ICollection<WorkContractRule> WorkContractRule { get; set; }
    }
}
