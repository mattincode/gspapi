using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Language
    {
        public Language()
        {
            FakeUserData = new HashSet<FakeUserData>();
            ReportLabelLanguage = new HashSet<ReportLabelLanguage>();
        }

        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string LangKey { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<FakeUserData> FakeUserData { get; set; }
        public virtual ICollection<ReportLabelLanguage> ReportLabelLanguage { get; set; }
    }
}
