using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitDefinition
    {
        public int PlanningUnitDefinitionId { get; set; }
        public string Name { get; set; }
        public string PlanningUnitNumber { get; set; }
        public int PlanningUnitTypeId { get; set; }
        public DateTime ValidFrom { get; set; }
        public int? SalarySupplementId { get; set; }
        public int? ProductId { get; set; }

        public virtual PlanningUnitType PlanningUnitType { get; set; }
    }
}
