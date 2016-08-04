using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ApplicationPartEntity
    {
        public int ApplicationPartId { get; set; }
        public int EntityId { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }

        public virtual ApplicationPart ApplicationPart { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
