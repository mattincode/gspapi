using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Contract
    {
        public Contract()
        {
            ContractPart = new HashSet<ContractPart>();
        }

        public int ContractId { get; set; }
        public string ContractNumber { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime? Terminate { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceAddressId { get; set; }
        public string ProfitCenterNumber { get; set; }

        public virtual ICollection<ContractPart> ContractPart { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual InvoiceAddress InvoiceAddress { get; set; }
    }
}
