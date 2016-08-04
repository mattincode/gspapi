using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class BookingCache
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public byte ScheduleType { get; set; }
        public bool IsOnFictivePlanningUnit { get; set; }
        public int? EmployeeId { get; set; }
        public int? PlanningUnitId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ChangeTraceId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int Duration { get; set; }
        public int Worktime { get; set; }
        public int TotalBreakLength { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
