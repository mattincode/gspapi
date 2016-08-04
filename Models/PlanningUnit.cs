using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnit
    {
        public PlanningUnit()
        {
            EmployeeMonthSalarySupplement = new HashSet<EmployeeMonthSalarySupplement>();
            EmployeePlanningUnitExperience = new HashSet<EmployeePlanningUnitExperience>();
            PlanningGroupPlanningUnit = new HashSet<PlanningGroupPlanningUnit>();
            PlanningUnitApproval = new HashSet<PlanningUnitApproval>();
            PlanningUnitCost = new HashSet<PlanningUnitCost>();
            PlanningUnitNote = new HashSet<PlanningUnitNote>();
            PlanningUnitQualification = new HashSet<PlanningUnitQualification>();
            PlanningUnitSalarySupplement = new HashSet<PlanningUnitSalarySupplement>();
            PlanningUnitSkill = new HashSet<PlanningUnitSkill>();
            PlanningUnitSpecification = new HashSet<PlanningUnitSpecification>();
            PlanningUnitVersion = new HashSet<PlanningUnitVersion>();
            SchedulingDataScheduleRow = new HashSet<SchedulingDataScheduleRow>();
            WorkContract = new HashSet<WorkContract>();
        }

        public int PlanningUnitId { get; set; }
        public string Name { get; set; }
        public string PlanningUnitNumber { get; set; }
        public int ProfitCenterId { get; set; }
        public int PlanningUnitTypeId { get; set; }
        public string AttendanceAddress { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string ContactName { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool IsKnowledgeRequired { get; set; }
        public bool BelongsToPreviousDay { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool ExportToGmp { get; set; }

        public virtual ICollection<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplement { get; set; }
        public virtual ICollection<EmployeePlanningUnitExperience> EmployeePlanningUnitExperience { get; set; }
        public virtual ICollection<PlanningGroupPlanningUnit> PlanningGroupPlanningUnit { get; set; }
        public virtual ICollection<PlanningUnitApproval> PlanningUnitApproval { get; set; }
        public virtual ICollection<PlanningUnitCost> PlanningUnitCost { get; set; }
        public virtual ICollection<PlanningUnitNote> PlanningUnitNote { get; set; }
        public virtual ICollection<PlanningUnitQualification> PlanningUnitQualification { get; set; }
        public virtual ICollection<PlanningUnitSalarySupplement> PlanningUnitSalarySupplement { get; set; }
        public virtual ICollection<PlanningUnitSkill> PlanningUnitSkill { get; set; }
        public virtual ICollection<PlanningUnitSpecification> PlanningUnitSpecification { get; set; }
        public virtual ICollection<PlanningUnitVersion> PlanningUnitVersion { get; set; }
        public virtual ICollection<SchedulingDataScheduleRow> SchedulingDataScheduleRow { get; set; }
        public virtual ICollection<WorkContract> WorkContract { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnitType PlanningUnitType { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
