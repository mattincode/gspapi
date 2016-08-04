using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Entity
    {
        public Entity()
        {
            ApplicationPartEntity = new HashSet<ApplicationPartEntity>();
            SecurityRoleEntityData = new HashSet<SecurityRoleEntityData>();
        }

        public int EntityId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string TypeName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<ApplicationPartEntity> ApplicationPartEntity { get; set; }
        public virtual EntityDefinition EntityDefinition { get; set; }
        public virtual ICollection<SecurityRoleEntityData> SecurityRoleEntityData { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
