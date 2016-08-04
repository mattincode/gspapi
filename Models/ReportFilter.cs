using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ReportFilter
    {
        public int ReportId { get; set; }
        public int FilterId { get; set; }
        public bool IsVisible { get; set; }
        public bool IsMandatory { get; set; }

        public virtual ReportFilter1 Filter { get; set; }
        public virtual Report Report { get; set; }
    }
}
