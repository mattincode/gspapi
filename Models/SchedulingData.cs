using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SchedulingData
    {
        public SchedulingData()
        {
            SchedulingDataRolloutHistory = new HashSet<SchedulingDataRolloutHistory>();
            SchedulingDataVersion = new HashSet<SchedulingDataVersion>();
        }

        public int SchedulingDataId { get; set; }
        public string SchedulingDataNumber { get; set; }
        public string Name { get; set; }
        public int ProfitCenterId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<SchedulingDataRolloutHistory> SchedulingDataRolloutHistory { get; set; }
        public virtual ICollection<SchedulingDataVersion> SchedulingDataVersion { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
