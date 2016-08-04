using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Printer
    {
        public Printer()
        {
            PrinterProfitCenter = new HashSet<PrinterProfitCenter>();
        }

        public int PrinterId { get; set; }
        public string Name { get; set; }
        public string Unc { get; set; }

        public virtual ICollection<PrinterProfitCenter> PrinterProfitCenter { get; set; }
    }
}
