using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportTerminalConfiguration
    {
        public AirportTerminalConfiguration()
        {
            AirportCheckpointConfiguration = new HashSet<AirportCheckpointConfiguration>();
            AirportStaffingContractHead = new HashSet<AirportStaffingContractHead>();
            AirportStaffingPrognosisParameter = new HashSet<AirportStaffingPrognosisParameter>();
        }

        public int AirportTerminalConfigurationId { get; set; }
        public int AirportConfigurationId { get; set; }
        public string Name { get; set; }
        public int? ProfitCenterId { get; set; }
        public int? AlternateProfitCenterId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportCheckpointConfiguration> AirportCheckpointConfiguration { get; set; }
        public virtual ICollection<AirportStaffingContractHead> AirportStaffingContractHead { get; set; }
        public virtual ICollection<AirportStaffingPrognosisParameter> AirportStaffingPrognosisParameter { get; set; }
        public virtual AirportConfiguration AirportConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
