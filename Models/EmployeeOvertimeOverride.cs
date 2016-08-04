using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EmployeeOvertimeOverride
    {
        public int EmployeeOvertimeOverrideId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public int? Hours { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
