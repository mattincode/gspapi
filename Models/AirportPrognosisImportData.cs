using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportPrognosisImportData
    {
        public int AirportPrognosisImportDataId { get; set; }
        public int AirportPrognosisImportDatasetId { get; set; }
        public DateTime Occasion { get; set; }
        public int Qualifier1 { get; set; }
        public int Qualifier2 { get; set; }
        public int Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AirportPrognosisImportDataset AirportPrognosisImportDataset { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
