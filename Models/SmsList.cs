using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SmsList
    {
        public SmsList()
        {
            SmsListRow = new HashSet<SmsListRow>();
        }

        public int SmsListId { get; set; }
        public string Name { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<SmsListRow> SmsListRow { get; set; }
        public virtual SystemUser CreatedByNavigation { get; set; }
        public virtual SystemUser ModifiedByNavigation { get; set; }
    }
}
