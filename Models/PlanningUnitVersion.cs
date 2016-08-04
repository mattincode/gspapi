using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitVersion
    {
        public PlanningUnitVersion()
        {
            PlanningUnitShift = new HashSet<PlanningUnitShift>();
            PlanningUnitSpecificationDayType = new HashSet<PlanningUnitSpecificationDayType>();
        }

        public int PlanningUnitVersionId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int PlanningUnitId { get; set; }
        public int? SalaryGroupId { get; set; }
        public bool IsHardWeek { get; set; }
        public TimeSpan? AllowBookingsOutsideShiftFrom { get; set; }
        public TimeSpan? AllowBookingsOutsideShiftTo { get; set; }
        public int? AllowBookingsOutsideShiftEmployeeCount { get; set; }
        public bool? AllowBookingsOutsideShiftVacancyOnCancelingBooking { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<PlanningUnitShift> PlanningUnitShift { get; set; }
        public virtual ICollection<PlanningUnitSpecificationDayType> PlanningUnitSpecificationDayType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
        public virtual SalaryGroup SalaryGroup { get; set; }
    }
}
