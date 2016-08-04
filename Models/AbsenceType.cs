using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AbsenceType
    {
        public AbsenceType()
        {
            AllowedEmploymentCategoryAbsenceType = new HashSet<AllowedEmploymentCategoryAbsenceType>();
        }

        public int AbsenceTypeId { get; set; }
        public string Name { get; set; }
        public bool AllowNotGranted { get; set; }
        public bool ResultsInOvertime { get; set; }
        public bool CreatesAbsenceBookings { get; set; }
        public bool AbsenceWorkAllowed { get; set; }
        public string ControlIntervalDays { get; set; }
        public bool CountsAsWorkTime { get; set; }
        public string ShortName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime? ImportedOn { get; set; }
        public bool ReducedWorkHours { get; set; }
        public string AllowedPercentages { get; set; }

        public virtual ICollection<AllowedEmploymentCategoryAbsenceType> AllowedEmploymentCategoryAbsenceType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
