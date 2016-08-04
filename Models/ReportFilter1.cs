using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ReportFilter1
    {
        public ReportFilter1()
        {
            ReportFilter = new HashSet<ReportFilter>();
        }

        public int FilterId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ReportFilter> ReportFilter { get; set; }
    }
}
