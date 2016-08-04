using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Product
    {
        public Product()
        {
            BookingSalarySupplement = new HashSet<BookingSalarySupplement>();
            EmployeeMonthSalarySupplement = new HashSet<EmployeeMonthSalarySupplement>();
            PlanningUnitSpecification = new HashSet<PlanningUnitSpecification>();
            ProductSalarySupplement = new HashSet<ProductSalarySupplement>();
        }

        public int ProductId { get; set; }
        public int ProductMasterId { get; set; }
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string Miscellaneous { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime? ImportedOn { get; set; }

        public virtual ICollection<BookingSalarySupplement> BookingSalarySupplement { get; set; }
        public virtual ICollection<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplement { get; set; }
        public virtual ICollection<PlanningUnitSpecification> PlanningUnitSpecification { get; set; }
        public virtual ICollection<ProductSalarySupplement> ProductSalarySupplement { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
