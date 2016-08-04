using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class JobRun
    {
        public int JobRunId { get; set; }
        public int JobTypeId { get; set; }
        public int? JobDefinitionId { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Finished { get; set; }
        public int Status { get; set; }
        public string StatusText { get; set; }
        public string Parameters { get; set; }
        public string Servername { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual JobDefinition JobDefinition { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
