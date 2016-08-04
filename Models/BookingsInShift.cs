using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class BookingsInShift
    {
        public int ShiftCacheId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Shifts ShiftCache { get; set; }
    }
}
