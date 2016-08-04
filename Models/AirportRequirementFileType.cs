using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportRequirementFileType
    {
        public int AirportRequirementFileTypeId { get; set; }
        public int AirportRequirementTypeId { get; set; }
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public string Filetypes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AirportRequirementType AirportRequirementType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
