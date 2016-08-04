using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class DayTypeRule
    {
        public DayTypeRule()
        {
            DaytypeRulePlanningUnitShift = new HashSet<DaytypeRulePlanningUnitShift>();
        }

        public int DayTypeRuleId { get; set; }
        public int DayTypeId { get; set; }
        public string Name { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public int DayTypeRuleTypeId { get; set; }
        public bool Holiday { get; set; }
        public bool Bankday { get; set; }
        public bool InconvenientHour { get; set; }

        public virtual ICollection<DaytypeRulePlanningUnitShift> DaytypeRulePlanningUnitShift { get; set; }
    }
}
