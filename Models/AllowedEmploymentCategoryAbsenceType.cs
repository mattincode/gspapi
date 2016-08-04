using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class AllowedEmploymentCategoryAbsenceType
    {
        public int AllowedEmploymentCategoryAbsenceTypeId { get; set; }
        public int AbsenceTypeId { get; set; }
        public int EmploymentCategoryId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual AbsenceType AbsenceType { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual EmploymentCategory EmploymentCategory { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
