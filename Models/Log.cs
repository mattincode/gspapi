using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public DateTime Date { get; set; }
        public DateTime BuildDate { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string SystemUser { get; set; }
        public string Exception { get; set; }
        public bool? Sent { get; set; }
    }
}
