using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EntityDefinition
    {
        public int EntityId { get; set; }
        public bool CreateEnabled { get; set; }
        public bool ReadEnabled { get; set; }
        public bool UpdateEnabled { get; set; }
        public bool DeleteEnabled { get; set; }

        public virtual Entity Entity { get; set; }
    }
}
