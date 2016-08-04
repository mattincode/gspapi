using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportCheckpointType
    {
        public AirportCheckpointType()
        {
            AirportCheckpointConfiguration = new HashSet<AirportCheckpointConfiguration>();
        }

        public int AirportCheckpointTypeId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportCheckpointConfiguration> AirportCheckpointConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
