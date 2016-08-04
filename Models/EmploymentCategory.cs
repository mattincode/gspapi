using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EmploymentCategory
    {
        public EmploymentCategory()
        {
            AllowedEmploymentCategoryAbsenceType = new HashSet<AllowedEmploymentCategoryAbsenceType>();
            Employment = new HashSet<Employment>();
        }

        public int EmploymentCategoryId { get; set; }
        public string EmploymentCategoryNumber { get; set; }
        public string Name { get; set; }
        public decimal DefaultHoursGuaranteed { get; set; }
        public byte DefaultTimePeriodType { get; set; }
        public bool IsGuaranteedHours { get; set; }
        public bool IsSchedulingAllowed { get; set; }
        public bool IsOverPerformanceAllowed { get; set; }
        public bool IsAdditionalTimeAllowed { get; set; }
        public bool IsOvertimeAllowed { get; set; }
        public bool AllowChangeOfPlanningPeriod { get; set; }
        public bool AllowMonthPlanning { get; set; }
        public bool AllowQuarterPlanning { get; set; }
        public bool AllowFifthQuarterPlanning { get; set; }
        public bool AllowYearPlanning { get; set; }
        public string Categorization { get; set; }
        public bool ShowInGsp { get; set; }
        public bool ShowInSep { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AllowedEmploymentCategoryAbsenceType> AllowedEmploymentCategoryAbsenceType { get; set; }
        public virtual ICollection<Employment> Employment { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
