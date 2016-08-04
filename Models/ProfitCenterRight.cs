using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ProfitCenterRight
    {
        public int ProfitCenterRightId { get; set; }
        public int ProfitCenterId { get; set; }
        public int SecurityRoleId { get; set; }
        public int SystemUserId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
        public virtual SystemUser SystemUser { get; set; }
    }
}
