using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class JobDefinition
    {
        public JobDefinition()
        {
            JobRun = new HashSet<JobRun>();
        }

        public int JobDefinitionId { get; set; }
        public int JobTypeId { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Parameters { get; set; }
        public bool Active { get; set; }
        public DateTime? LastRunTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<JobRun> JobRun { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
