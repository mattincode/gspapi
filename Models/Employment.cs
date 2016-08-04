using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Employment
    {
        public Employment()
        {
            EmploymentHoursGuaranteed = new HashSet<EmploymentHoursGuaranteed>();
        }

        public int EmploymentId { get; set; }
        public int EmployeeId { get; set; }
        public int ProfitCenterId { get; set; }
        public int EmploymentCategoryId { get; set; }
        public int EmploymentFormTypeId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal HoursGuaranteed { get; set; }
        public decimal OvertimeAllowedHours { get; set; }
        public byte TimePeriodType { get; set; }
        public int? PersonalContractId { get; set; }
        public int? UnionContractId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<EmploymentHoursGuaranteed> EmploymentHoursGuaranteed { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual EmploymentCategory EmploymentCategory { get; set; }
        public virtual EmploymentFormType EmploymentFormType { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual WorkContract PersonalContract { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
        public virtual WorkContract UnionContract { get; set; }
    }
}
