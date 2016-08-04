using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class FakeUserData
    {
        public int FakeUserDataId { get; set; }
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Gender { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Telephone1 { get; set; }
        public short PeriodLength { get; set; }
        public byte TimePeriodType { get; set; }

        public virtual Language Language { get; set; }
    }
}
