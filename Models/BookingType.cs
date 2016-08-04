using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class BookingType
    {
        public int BookingTypeId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool DoubleBookingOnEmployeeAllowed { get; set; }
        public bool DoubleBookingOnEmployeeRequired { get; set; }
        public bool DoubleBookingOnPlanningUnitAllowed { get; set; }
        public bool DoubleBookingOnPlanningUnitRequired { get; set; }
        public bool IncludedInStatutoryEducation { get; set; }
        public bool AllowedOnPlannedSchedule { get; set; }
        public bool IsWorkTime { get; set; }
        public bool DoubleBookingOnEmployeeBreakRequired { get; set; }
        public bool ConsumesVacancies { get; set; }
        public bool IsLearningTime { get; set; }
        public int? WorkContractId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual WorkContract WorkContract { get; set; }
    }
}
