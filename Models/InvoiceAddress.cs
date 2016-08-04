using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class InvoiceAddress
    {
        public InvoiceAddress()
        {
            Contract = new HashSet<Contract>();
            ContractPart = new HashSet<ContractPart>();
        }

        public int InvoiceAddressId { get; set; }
        public string InvoiceAddressNumber { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<ContractPart> ContractPart { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
