using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingPrognosis
    {
        public AirportStaffingPrognosis()
        {
            AirportPrognosisImportDataset = new HashSet<AirportPrognosisImportDataset>();
            AirportStaffingContractHead = new HashSet<AirportStaffingContractHead>();
            AirportStaffingPlanningUnitParameter = new HashSet<AirportStaffingPlanningUnitParameter>();
            AirportStaffingPrognosisBooking = new HashSet<AirportStaffingPrognosisBooking>();
            AirportStaffingPrognosisEmployee = new HashSet<AirportStaffingPrognosisEmployee>();
            AirportStaffingPrognosisParameter = new HashSet<AirportStaffingPrognosisParameter>();
            AirportStaffingStaff = new HashSet<AirportStaffingStaff>();
        }

        public int AirportStaffingPrognosisId { get; set; }
        public int AirportConfigurationId { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int State { get; set; }
        public string StaffingDataOnImport { get; set; }
        public string StaffingData { get; set; }
        public int? VacancySimulationNo { get; set; }
        public int? StaffingSimulationNo { get; set; }
        public int? JobRunId { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<AirportPrognosisImportDataset> AirportPrognosisImportDataset { get; set; }
        public virtual ICollection<AirportStaffingContractHead> AirportStaffingContractHead { get; set; }
        public virtual ICollection<AirportStaffingPlanningUnitParameter> AirportStaffingPlanningUnitParameter { get; set; }
        public virtual ICollection<AirportStaffingPrognosisBooking> AirportStaffingPrognosisBooking { get; set; }
        public virtual ICollection<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployee { get; set; }
        public virtual ICollection<AirportStaffingPrognosisParameter> AirportStaffingPrognosisParameter { get; set; }
        public virtual ICollection<AirportStaffingStaff> AirportStaffingStaff { get; set; }
        public virtual AirportConfiguration AirportConfiguration { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
