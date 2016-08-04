using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class WorkContractRule
    {
        public int WorkContractRuleId { get; set; }
        public int WorkContractId { get; set; }
        public int WorkContractParameterId { get; set; }
        public decimal Value { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual WorkContract WorkContract { get; set; }
        public virtual WorkContractParameter WorkContractParameter { get; set; }
    }
}
