using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportRequirementType
    {
        public AirportRequirementType()
        {
            AirportPrognosisImportDataset = new HashSet<AirportPrognosisImportDataset>();
            AirportRequirementFileType = new HashSet<AirportRequirementFileType>();
        }

        public int AirportRequirementTypeId { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportPrognosisImportDataset> AirportPrognosisImportDataset { get; set; }
        public virtual ICollection<AirportRequirementFileType> AirportRequirementFileType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
