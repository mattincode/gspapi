using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class VacancyPlanningSimulation
    {
        public int VacancyPlanningSimulationId { get; set; }
        public string Name { get; set; }
        public int ProfitCenterId { get; set; }
        public string Query { get; set; }
        public string Operations { get; set; }
        public DateTime? ExecutedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
