using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ValidBookings
    {
        public int BookingId { get; set; }
        public byte ScheduleType { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int ChangeTraceId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
