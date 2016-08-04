using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class JobConfig
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public string ServerName { get; set; }

        public virtual JobType JobType { get; set; }
    }
}
