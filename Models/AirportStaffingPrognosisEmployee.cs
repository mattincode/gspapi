using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingPrognosisEmployee
    {
        public AirportStaffingPrognosisEmployee()
        {
            AirportStaffingPrognosisBooking = new HashSet<AirportStaffingPrognosisBooking>();
        }

        public int AirportStaffingPrognosisEmployeeId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public byte DataType { get; set; }
        public int? SimulationNo { get; set; }
        public bool IsFakeUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProfitCenterId { get; set; }
        public int? EmployeeId { get; set; }
        public byte Gender { get; set; }
        public int? QualificationId { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Telephone1 { get; set; }
        public short PeriodLength { get; set; }
        public byte TimePeriodType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportStaffingPrognosisBooking> AirportStaffingPrognosisBooking { get; set; }
        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
        public virtual Qualification Qualification { get; set; }
    }
}
