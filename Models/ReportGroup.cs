using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ReportGroup
    {
        public ReportGroup()
        {
            Report = new HashSet<Report>();
        }

        public int GroupId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Report> Report { get; set; }
    }
}
