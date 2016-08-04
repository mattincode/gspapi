using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AirportStaffingStaff
    {
        public int AirportStaffingStaffId { get; set; }
        public int AirportStaffingPrognosisId { get; set; }
        public int SimulationNo { get; set; }
        public int EmployeeId { get; set; }
        public byte Gender { get; set; }
        public int? QualificationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AirportStaffingPrognosis AirportStaffingPrognosis { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
