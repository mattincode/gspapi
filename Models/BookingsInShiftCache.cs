using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class BookingsInShiftCache
    {
        public int ShiftCacheId { get; set; }
        public int BookingId { get; set; }

        public virtual ShiftCache ShiftCache { get; set; }
    }
}
