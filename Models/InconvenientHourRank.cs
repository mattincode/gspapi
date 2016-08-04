using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class InconvenientHourRank
    {
        public InconvenientHourRank()
        {
            InconvenientHourCalendar = new HashSet<InconvenientHourCalendar>();
        }

        public int InconvenientHourRankId { get; set; }
        public int? WorkContractId { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int Rank { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<InconvenientHourCalendar> InconvenientHourCalendar { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual WorkContract WorkContract { get; set; }
    }
}
