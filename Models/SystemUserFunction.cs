using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SystemUserFunction
    {
        public int SystemUserFunctionId { get; set; }
        public string Name { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
