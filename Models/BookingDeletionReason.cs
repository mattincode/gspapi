using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class BookingDeletionReason
    {
        public int BookingDeletionReasonId { get; set; }
        public string Reason { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
    }
}
