using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingContractRule
    {
        public int AirportStaffingContractRuleId { get; set; }
        public int AirportStaffingContractHeadId { get; set; }
        public string Rule { get; set; }
        public decimal OrgValue { get; set; }
        public decimal NewValue { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual AirportStaffingContractHead AirportStaffingContractHead { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
