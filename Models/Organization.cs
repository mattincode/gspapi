using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Organization
    {
        public int OrganizationBranchId { get; set; }
        public string OrgPath { get; set; }
        public short? OrgLevel { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
