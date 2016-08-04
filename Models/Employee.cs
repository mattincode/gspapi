using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AirportConfigurationEmployee = new HashSet<AirportConfigurationEmployee>();
            AirportStaffingPrognosisEmployee = new HashSet<AirportStaffingPrognosisEmployee>();
            EmployeeApproval = new HashSet<EmployeeApproval>();
            EmployeeDateInterval = new HashSet<EmployeeDateInterval>();
            EmployeeFictiveSchedulingData = new HashSet<EmployeeFictiveSchedulingData>();
            EmployeeImage = new HashSet<EmployeeImage>();
            EmployeeMonthSalarySupplement = new HashSet<EmployeeMonthSalarySupplement>();
            EmployeeNote = new HashSet<EmployeeNote>();
            EmployeeOvertimeOverride = new HashSet<EmployeeOvertimeOverride>();
            EmployeePlanningUnitExperience = new HashSet<EmployeePlanningUnitExperience>();
            EmployeeQualification = new HashSet<EmployeeQualification>();
            EmployeeSalarySupplement = new HashSet<EmployeeSalarySupplement>();
            EmployeeSkill = new HashSet<EmployeeSkill>();
            EmployeeUnionTrustee = new HashSet<EmployeeUnionTrustee>();
            Employment = new HashSet<Employment>();
            PlanningPeriod = new HashSet<PlanningPeriod>();
            SchedulingDataRolloutHistory = new HashSet<SchedulingDataRolloutHistory>();
            SchedulingDataVersionEmployee = new HashSet<SchedulingDataVersionEmployee>();
            ShiftCache = new HashSet<ShiftCache>();
            Shifts = new HashSet<Shifts>();
            SmsListRow = new HashSet<SmsListRow>();
        }

        public int EmployeeId { get; set; }
        public int EmployeeNumber { get; set; }
        public string DomainName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonLegalId { get; set; }
        public byte Gender { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string City2 { get; set; }
        public string PostalCode { get; set; }
        public string PostalCode2 { get; set; }
        public string CareOfAddress { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Telephone3 { get; set; }
        public string EmailAddress1 { get; set; }
        public string EmailAddress2 { get; set; }
        public string MainWorkPlace { get; set; }
        public string Beeper { get; set; }
        public DateTime? EmployedFrom { get; set; }
        public DateTime? EmployedTo { get; set; }
        public bool Inactive { get; set; }
        public bool FakeUser { get; set; }
        public bool AbsenceWorkAllowed { get; set; }
        public DateTime? DontSendToHr { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int? ExternalId { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool PrefersPrintedSchema { get; set; }

        public virtual ICollection<AirportConfigurationEmployee> AirportConfigurationEmployee { get; set; }
        public virtual ICollection<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployee { get; set; }
        public virtual ICollection<EmployeeApproval> EmployeeApproval { get; set; }
        public virtual ICollection<EmployeeDateInterval> EmployeeDateInterval { get; set; }
        public virtual ICollection<EmployeeFictiveSchedulingData> EmployeeFictiveSchedulingData { get; set; }
        public virtual ICollection<EmployeeImage> EmployeeImage { get; set; }
        public virtual ICollection<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplement { get; set; }
        public virtual ICollection<EmployeeNote> EmployeeNote { get; set; }
        public virtual ICollection<EmployeeOvertimeOverride> EmployeeOvertimeOverride { get; set; }
        public virtual ICollection<EmployeePlanningUnitExperience> EmployeePlanningUnitExperience { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual ICollection<EmployeeSalarySupplement> EmployeeSalarySupplement { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkill { get; set; }
        public virtual ICollection<EmployeeUnionTrustee> EmployeeUnionTrustee { get; set; }
        public virtual ICollection<Employment> Employment { get; set; }
        public virtual ICollection<PlanningPeriod> PlanningPeriod { get; set; }
        public virtual ICollection<SchedulingDataRolloutHistory> SchedulingDataRolloutHistory { get; set; }
        public virtual ICollection<SchedulingDataVersionEmployee> SchedulingDataVersionEmployee { get; set; }
        public virtual ICollection<ShiftCache> ShiftCache { get; set; }
        public virtual ICollection<Shifts> Shifts { get; set; }
        public virtual ICollection<SmsListRow> SmsListRow { get; set; }
    }
}
