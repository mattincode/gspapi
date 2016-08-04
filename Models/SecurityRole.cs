using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            ProfitCenterRight = new HashSet<ProfitCenterRight>();
            SecurityRoleAppPartData = new HashSet<SecurityRoleAppPartData>();
            SecurityRoleEntityData = new HashSet<SecurityRoleEntityData>();
        }

        public int SecurityRoleId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<ProfitCenterRight> ProfitCenterRight { get; set; }
        public virtual ICollection<SecurityRoleAppPartData> SecurityRoleAppPartData { get; set; }
        public virtual ICollection<SecurityRoleEntityData> SecurityRoleEntityData { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
