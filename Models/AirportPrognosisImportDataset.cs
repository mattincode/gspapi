using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportPrognosisImportDataset
    {
        public AirportPrognosisImportDataset()
        {
            AirportPrognosisImportData = new HashSet<AirportPrognosisImportData>();
        }

        public int AirportPrognosisImportDatasetId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public int AirportRequirementTypeId { get; set; }
        public int? SubType { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<AirportPrognosisImportData> AirportPrognosisImportData { get; set; }
        public virtual AirportRequirementType AirportRequirementType { get; set; }
        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
