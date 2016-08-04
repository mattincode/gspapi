using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class CustomerObject
    {
        public CustomerObject()
        {
            ContractPart = new HashSet<ContractPart>();
        }

        public int CustomerObjectId { get; set; }
        public string CustomerObjectNumber { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ProfitCenterNumber { get; set; }

        public virtual ICollection<ContractPart> ContractPart { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
