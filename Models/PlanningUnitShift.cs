using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitShift
    {
        public PlanningUnitShift()
        {
            DaytypePlanningUnitShift = new HashSet<DaytypePlanningUnitShift>();
            DaytypeRulePlanningUnitShift = new HashSet<DaytypeRulePlanningUnitShift>();
            PlanningUnitShiftBreak = new HashSet<PlanningUnitShiftBreak>();
        }

        public int PlanningUnitShiftId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public double DurationInMinutes { get; set; }
        public int VacancyCodeId { get; set; }
        public int PlanningUnitVersionId { get; set; }
        public int EmployeeCount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<DaytypePlanningUnitShift> DaytypePlanningUnitShift { get; set; }
        public virtual ICollection<DaytypeRulePlanningUnitShift> DaytypeRulePlanningUnitShift { get; set; }
        public virtual ICollection<PlanningUnitShiftBreak> PlanningUnitShiftBreak { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnitVersion PlanningUnitVersion { get; set; }
        public virtual VacancyCode VacancyCode { get; set; }
    }
}
