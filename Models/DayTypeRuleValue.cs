using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class DayTypeRuleValue
    {
        public int DayTypeRuleValueId { get; set; }
        public int DayTypeRuleId { get; set; }
        public string StringValue { get; set; }
        public int? IntegerValue { get; set; }
        public DateTime? DateValue { get; set; }
        public int DayTypeRuleValueTypeId { get; set; }
    }
}
