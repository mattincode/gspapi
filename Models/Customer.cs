using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Contract = new HashSet<Contract>();
            CustomerObject = new HashSet<CustomerObject>();
            InvoiceAddress = new HashSet<InvoiceAddress>();
        }

        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<CustomerObject> CustomerObject { get; set; }
        public virtual ICollection<InvoiceAddress> InvoiceAddress { get; set; }
    }
}
