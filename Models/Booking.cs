using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Booking
    {
        public Booking()
        {
            BookingSalarySupplement = new HashSet<BookingSalarySupplement>();
            BookingsInShift = new HashSet<BookingsInShift>();
        }

        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? PlanningUnitId { get; set; }
        public int? BookingTypeId { get; set; }
        public int? AbsenceTypeId { get; set; }
        public bool? AbsenceGranted { get; set; }
        public double? AbsencePercentage { get; set; }
        public bool IsScheduled { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public int? BookingDeletionReasonId { get; set; }
        public string BreakXml { get; set; }
        public int? CreatedBySchedulingDataId { get; set; }
        public bool TimeBelongsToPreviousMonth { get; set; }
        public bool ManuallyCreated { get; set; }
        public int ChangeTraceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<BookingSalarySupplement> BookingSalarySupplement { get; set; }
        public virtual ICollection<BookingsInShift> BookingsInShift { get; set; }
        public virtual ValidBookings ValidBookings { get; set; }
    }
}
