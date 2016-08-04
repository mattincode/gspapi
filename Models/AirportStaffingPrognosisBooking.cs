using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingPrognosisBooking
    {
        public int AirportStaffingPrognosisBookingId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public byte DataType { get; set; }
        public int? SimulationNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? AirportStaffingPrognosisEmployeeId { get; set; }
        public int? PlanningUnitId { get; set; }
        public string PlanningUnitNumber { get; set; }
        public int? ProfitCenterId { get; set; }
        public string ProfitCenterNumber { get; set; }
        public int? BookingTypeId { get; set; }
        public string BookingTypeName { get; set; }
        public string BookingTypeShortName { get; set; }
        public int? AbsenceTypeId { get; set; }
        public string AbsenceTypeName { get; set; }
        public bool? AbsenceGranted { get; set; }
        public double? AbsencePercentage { get; set; }
        public bool IsScheduled { get; set; }
        public bool IsDeleted { get; set; }
        public string BreakXml { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AirportStaffingPrognosisEmployee AirportStaffingPrognosisEmployee { get; set; }
        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
