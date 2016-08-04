using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class PlanningUnitSpecification
    {
        public int PlanningUnitSpecificationId { get; set; }
        public int PlanningUnitId { get; set; }
        public int? ProfitCenterId { get; set; }
        public int? SalarySupplementId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual PlanningUnit PlanningUnit { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProfitCenter ProfitCenter { get; set; }
    }
}
