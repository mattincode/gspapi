using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SecurityRoleEntityData
    {
        public int SecurityRoleEntityDataId { get; set; }
        public int SecurityRoleId { get; set; }
        public int EntityId { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
    }
}
