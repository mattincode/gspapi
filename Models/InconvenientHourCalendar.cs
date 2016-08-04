using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class InconvenientHourCalendar
    {
        public int InconvenientHourCalendarId { get; set; }
        public int? DayTypeId { get; set; }
        public int? DayTypeRuleId { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int WorkContractId { get; set; }
        public int InconvenientHourRankId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual InconvenientHourRank InconvenientHourRank { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual WorkContract WorkContract { get; set; }
    }
}
