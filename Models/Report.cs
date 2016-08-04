using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Report
    {
        public Report()
        {
            ReportFilter = new HashSet<ReportFilter>();
            ReportView = new HashSet<ReportView>();
        }

        public int ReportId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public bool OneProfitCenterOnly { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<ReportFilter> ReportFilter { get; set; }
        public virtual ICollection<ReportView> ReportView { get; set; }
        public virtual ReportGroup Group { get; set; }
    }
}
