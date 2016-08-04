using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ContractPart
    {
        public int ContractPartId { get; set; }
        public string ContractPartNumber { get; set; }
        public int ContractId { get; set; }
        public int? CustomerObjectId { get; set; }
        public int? InvoiceAddressId { get; set; }
        public string ProfitCenterNumber { get; set; }
        public string ProductNumber { get; set; }
        public int AgreedMinutesDay { get; set; }
        public int AgreedMinutesWeek { get; set; }
        public int AgreedMinutesMonth { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual CustomerObject CustomerObject { get; set; }
        public virtual InvoiceAddress InvoiceAddress { get; set; }
    }
}
