using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Shifts
    {
        public Shifts()
        {
            BookingsInShift = new HashSet<BookingsInShift>();
        }

        public int ShiftId { get; set; }
        public bool IsScheduled { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<BookingsInShift> BookingsInShift { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
