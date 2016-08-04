using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ApplicationPart
    {
        public ApplicationPart()
        {
            ApplicationPartEntity = new HashSet<ApplicationPartEntity>();
            SecurityRoleAppPartData = new HashSet<SecurityRoleAppPartData>();
        }

        public int ApplicationPartId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string TypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<ApplicationPartEntity> ApplicationPartEntity { get; set; }
        public virtual ICollection<SecurityRoleAppPartData> SecurityRoleAppPartData { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
