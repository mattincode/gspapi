using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ShiftCache
    {
        public ShiftCache()
        {
            BookingsInShiftCache = new HashSet<BookingsInShiftCache>();
        }

        public int ShiftCacheId { get; set; }
        public bool IsScheduled { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Duration { get; set; }
        public int TotalBreaksDuration { get; set; }
        public int Worktime { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<BookingsInShiftCache> BookingsInShiftCache { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
