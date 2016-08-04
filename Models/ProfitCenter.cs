using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ProfitCenter
    {
        public ProfitCenter()
        {
            AirportStaffingPrognosisEmployee = new HashSet<AirportStaffingPrognosisEmployee>();
            Employment = new HashSet<Employment>();
            FictiveSchedulingData = new HashSet<FictiveSchedulingData>();
            FictiveSchedulingShiftTypeHour = new HashSet<FictiveSchedulingShiftTypeHour>();
            PlanningGroup = new HashSet<PlanningGroup>();
            PlanningUnit = new HashSet<PlanningUnit>();
            PlanningUnitSpecification = new HashSet<PlanningUnitSpecification>();
            PrinterProfitCenter = new HashSet<PrinterProfitCenter>();
            ProfitCenterRight = new HashSet<ProfitCenterRight>();
            SchedulingData = new HashSet<SchedulingData>();
            VacancyPlanningSimulation = new HashSet<VacancyPlanningSimulation>();
            WorkContract = new HashSet<WorkContract>();
        }

        public int ProfitCenterId { get; set; }
        public string ProfitCenterNumber { get; set; }
        public string Name { get; set; }
        public bool Plannable { get; set; }
        public bool PublishToEmployeePortal { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool? IsAdministrative { get; set; }

        public virtual ICollection<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployee { get; set; }
        public virtual ICollection<Employment> Employment { get; set; }
        public virtual ICollection<FictiveSchedulingData> FictiveSchedulingData { get; set; }
        public virtual ICollection<FictiveSchedulingShiftTypeHour> FictiveSchedulingShiftTypeHour { get; set; }
        public virtual ICollection<PlanningGroup> PlanningGroup { get; set; }
        public virtual ICollection<PlanningUnit> PlanningUnit { get; set; }
        public virtual ICollection<PlanningUnitSpecification> PlanningUnitSpecification { get; set; }
        public virtual ICollection<PrinterProfitCenter> PrinterProfitCenter { get; set; }
        public virtual ICollection<ProfitCenterRight> ProfitCenterRight { get; set; }
        public virtual ICollection<SchedulingData> SchedulingData { get; set; }
        public virtual ICollection<VacancyPlanningSimulation> VacancyPlanningSimulation { get; set; }
        public virtual ICollection<WorkContract> WorkContract { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
