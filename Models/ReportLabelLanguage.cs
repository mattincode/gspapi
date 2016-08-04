using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ReportLabelLanguage
    {
        public int ReportLabelLanguageId { get; set; }
        public int LanguageId { get; set; }
        public string ReportName { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public virtual Language Language { get; set; }
    }
}
