using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SecurityRoleAppPartData
    {
        public int SecurityRoleAppPartDataId { get; set; }
        public int SecurityRoleId { get; set; }
        public int ApplicationPartId { get; set; }
        public bool HasRight { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ApplicationPart ApplicationPart { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
    }
}
