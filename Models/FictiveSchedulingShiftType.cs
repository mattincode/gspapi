using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class FictiveSchedulingShiftType
    {
        public FictiveSchedulingShiftType()
        {
            FictiveSchedulingShift = new HashSet<FictiveSchedulingShift>();
            FictiveSchedulingShiftTypeHour = new HashSet<FictiveSchedulingShiftTypeHour>();
        }

        public int FictiveSchedulingShiftTypeId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<FictiveSchedulingShift> FictiveSchedulingShift { get; set; }
        public virtual ICollection<FictiveSchedulingShiftTypeHour> FictiveSchedulingShiftTypeHour { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
