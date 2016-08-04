using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SmsLog
    {
        public int SmsLogId { get; set; }
        public string SmsLogXml { get; set; }
        public bool Succeeded { get; set; }
        public string ErrorLog { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
    }
}
