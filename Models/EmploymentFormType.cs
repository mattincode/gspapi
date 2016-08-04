using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class EmploymentFormType
    {
        public EmploymentFormType()
        {
            Employment = new HashSet<Employment>();
        }

        public int EmploymentFormTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employment> Employment { get; set; }
    }
}
