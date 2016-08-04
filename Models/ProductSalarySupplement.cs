using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class ProductSalarySupplement
    {
        public int ProductSalarySupplementId { get; set; }
        public int ProductId { get; set; }
        public int SalarySupplementId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime? ImportedOn { get; set; }
        public int? MasterId { get; set; }

        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual SalarySupplement SalarySupplement { get; set; }
    }
}
