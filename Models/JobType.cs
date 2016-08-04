using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class JobType
    {
        public JobType()
        {
            JobConfig = new HashSet<JobConfig>();
        }

        public int JobTypeId { get; set; }
        public string Name { get; set; }
        public bool PeriodicAllowed { get; set; }
        public bool IsSystemJob { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<JobConfig> JobConfig { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
