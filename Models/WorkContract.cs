using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class WorkContract
    {
        public WorkContract()
        {
            BookingType = new HashSet<BookingType>();
            EmploymentPersonalContract = new HashSet<Employment>();
            EmploymentUnionContract = new HashSet<Employment>();
            InconvenientHourCalendar = new HashSet<InconvenientHourCalendar>();
            InconvenientHourRank = new HashSet<InconvenientHourRank>();
            WorkContractRule = new HashSet<WorkContractRule>();
        }

        public int WorkContractId { get; set; }
        public string Description { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public byte WorkContractType { get; set; }
        public int? UnionId { get; set; }
        public int? PlanningUnitId { get; set; }
        public int? ProfitCenterId { get; set; }
        public int? FirstDayOfWeek { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ExternalId { get; set; }
        public bool ExtendObtime1 { get; set; }

        public virtual ICollection<BookingType> BookingType { get; set; }
        public virtual ICollection<Employment> EmploymentPersonalContract { get; set; }
        public virtual ICollection<Employment> EmploymentUnionContract { get; set; }
        public virtual ICollection<InconvenientHourCalendar> InconvenientHourCalendar { get; set; }
        public virtual ICollection<InconvenientHourRank> InconvenientHourRank { get; set; }
        public virtual ICollection<WorkContractRule> WorkContractRule { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
        public virtual Union Union { get; set; }
    }
}
