using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class FictiveSchedulingData
    {
        public FictiveSchedulingData()
        {
            EmployeeFictiveSchedulingData = new HashSet<EmployeeFictiveSchedulingData>();
            FictiveSchedulingShift = new HashSet<FictiveSchedulingShift>();
        }

        public int FictiveSchedulingDataId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int ProfitCenterId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<EmployeeFictiveSchedulingData> EmployeeFictiveSchedulingData { get; set; }
        public virtual ICollection<FictiveSchedulingShift> FictiveSchedulingShift { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
