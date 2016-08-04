using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SalaryRun
    {
        public int SalaryRunId { get; set; }
        public DateTime RunDate { get; set; }
        public DateTime SalaryMonth { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
    }
}
