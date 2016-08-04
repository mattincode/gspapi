using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SalarySupplement
    {
        public SalarySupplement()
        {
            BookingSalarySupplement = new HashSet<BookingSalarySupplement>();
            EmployeeMonthSalarySupplement = new HashSet<EmployeeMonthSalarySupplement>();
            EmployeeSalarySupplement = new HashSet<EmployeeSalarySupplement>();
            PlanningUnitSalarySupplement = new HashSet<PlanningUnitSalarySupplement>();
            PlanningUnitTypeSalarySupplement = new HashSet<PlanningUnitTypeSalarySupplement>();
            ProductSalarySupplement = new HashSet<ProductSalarySupplement>();
        }

        public int SalarySupplementId { get; set; }
        public string SalarySupplementNumber { get; set; }
        public string Name { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool ValidWhenConnectionsExist { get; set; }
        public bool IsWorkTime { get; set; }
        public bool Quantity { get; set; }
        public bool Amount { get; set; }
        public double? MaxQuantity { get; set; }
        public double? MaxAmount { get; set; }
        public bool CanConnectToPlanningUnit { get; set; }
        public bool CanConnectToPlanningUnitSpecification { get; set; }
        public bool CanConnectToTimeAccounting { get; set; }
        public bool CanConnectToEmployee { get; set; }
        public bool DeclareAsDirectTime { get; set; }
        public bool DeclareAsIndirectTime { get; set; }
        public bool CanConnectToManualBookings { get; set; }
        public bool DeclareAsExtraTime { get; set; }
        public bool DeclareAsStipulatedTime { get; set; }
        public bool DeclareAsIndirectAdminTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime? ImportedOn { get; set; }

        public virtual ICollection<BookingSalarySupplement> BookingSalarySupplement { get; set; }
        public virtual ICollection<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplement { get; set; }
        public virtual ICollection<EmployeeSalarySupplement> EmployeeSalarySupplement { get; set; }
        public virtual ICollection<PlanningUnitSalarySupplement> PlanningUnitSalarySupplement { get; set; }
        public virtual ICollection<PlanningUnitTypeSalarySupplement> PlanningUnitTypeSalarySupplement { get; set; }
        public virtual ICollection<ProductSalarySupplement> ProductSalarySupplement { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
