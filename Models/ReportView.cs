using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ReportView
    {
        public int ReportId { get; set; }
        public int ViewId { get; set; }

        public virtual Report Report { get; set; }
    }
}
