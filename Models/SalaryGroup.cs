using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SalaryGroup
    {
        public SalaryGroup()
        {
            PlanningUnitVersion = new HashSet<PlanningUnitVersion>();
        }

        public int SalaryGroupId { get; set; }
        public string Name { get; set; }
        public string SalaryGroupNumber { get; set; }
        public bool ShowInGsp { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int? MasterId { get; set; }

        public virtual ICollection<PlanningUnitVersion> PlanningUnitVersion { get; set; }
    }
}
