using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ProfitCenterLocking
    {
        public int ProfitCenterId { get; set; }
        public string AppServerName { get; set; }
        public DateTime? LockCreated { get; set; }
        public int? JobRunId { get; set; }
    }
}
