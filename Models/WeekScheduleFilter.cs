using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class WeekScheduleFilter
    {
        public int WeekScheduleFilterId { get; set; }
        public int SystemUserId { get; set; }
        public bool ShowEmployeeName { get; set; }
        public bool ShowEmployeeSexMale { get; set; }
        public bool ShowEmployeeSexFemale { get; set; }
        public bool ShowPlanningUnitName { get; set; }
        public bool ShowAbsenceBookings { get; set; }
        public bool ShowDeletedBookings { get; set; }
        public bool ShowVacancies { get; set; }
        public bool ShowStaffingBookings { get; set; }
        public bool ShowResourceBookings { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual SystemUser SystemUser { get; set; }
    }
}
