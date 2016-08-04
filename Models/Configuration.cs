using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Configuration
    {
        public int ConfigurationId { get; set; }
        public string Name { get; set; }
        public bool? BoolValue { get; set; }
        public string StringValue { get; set; }
    }
}
