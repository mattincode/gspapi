using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Qualification
    {
        public Qualification()
        {
            AirportCheckpointStaffConfiguration = new HashSet<AirportCheckpointStaffConfiguration>();
            AirportStaffingPrognosisEmployee = new HashSet<AirportStaffingPrognosisEmployee>();
            EmployeeQualification = new HashSet<EmployeeQualification>();
            PlanningGroupGenderConstraint = new HashSet<PlanningGroupGenderConstraint>();
            PlanningUnitQualification = new HashSet<PlanningUnitQualification>();
        }

        public int QualificationId { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportCheckpointStaffConfiguration> AirportCheckpointStaffConfiguration { get; set; }
        public virtual ICollection<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployee { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual ICollection<PlanningGroupGenderConstraint> PlanningGroupGenderConstraint { get; set; }
        public virtual ICollection<PlanningUnitQualification> PlanningUnitQualification { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
