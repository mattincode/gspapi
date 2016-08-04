using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningPeriodDateDefinition
    {
        public int PlanningPeriodDateDefinitionId { get; set; }
        public DateTime EndDate { get; set; }
        public short PeriodLength { get; set; }
        public byte TimePeriodType { get; set; }
        public DateTime StartDate { get; set; }
        public short NewPeriodLength { get; set; }
        public byte NewTimePeriodType { get; set; }
    }
}
