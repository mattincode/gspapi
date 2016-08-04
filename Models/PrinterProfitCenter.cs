using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PrinterProfitCenter
    {
        public int PrinterId { get; set; }
        public int ProfitCenterId { get; set; }

        public virtual Printer Printer { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
