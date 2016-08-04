using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class BookingSalarySupplement
    {
        public int BookingSalarySupplementId { get; set; }
        public int BookingId { get; set; }
        public int SalarySupplementId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual SalarySupplement SalarySupplement { get; set; }
    }
}
