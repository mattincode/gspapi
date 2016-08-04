using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningGroup
    {
        public PlanningGroup()
        {
            AirportCheckpointConfiguration = new HashSet<AirportCheckpointConfiguration>();
            PlanningGroupGenderConstraint = new HashSet<PlanningGroupGenderConstraint>();
            PlanningGroupPlanningUnit = new HashSet<PlanningGroupPlanningUnit>();
        }

        public int PlanningGroupId { get; set; }
        public int ProfitCenterId { get; set; }
        public string PlanningGroupNumber { get; set; }
        public int PlanningGroupTypeId { get; set; }
        public string PlanningGroupName { get; set; }
        public string AttendanceAddress { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string EmailAddress { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AirportCheckpointConfiguration> AirportCheckpointConfiguration { get; set; }
        public virtual ICollection<PlanningGroupGenderConstraint> PlanningGroupGenderConstraint { get; set; }
        public virtual ICollection<PlanningGroupPlanningUnit> PlanningGroupPlanningUnit { get; set; }
        public virtual PlanningGroupType PlanningGroupType { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
