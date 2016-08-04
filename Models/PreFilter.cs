using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PreFilter
    {
        public int PrefilterId { get; set; }
        public string Filter { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual SystemUser User { get; set; }
    }
}
