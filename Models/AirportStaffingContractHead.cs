using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingContractHead
    {
        public AirportStaffingContractHead()
        {
            AirportStaffingContractRule = new HashSet<AirportStaffingContractRule>();
        }

        public int AirportStaffingContractHeadId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public int AirportTerminalConfigurationId { get; set; }
        public string ContractName { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<AirportStaffingContractRule> AirportStaffingContractRule { get; set; }
        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual AirportTerminalConfiguration AirportTerminalConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
