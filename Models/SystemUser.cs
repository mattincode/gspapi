using System;
using System.Collections.Generic;

namespace gspApi.Models
{
    public partial class SystemUser
    {
        public SystemUser()
        {
            AbsenceTypeCreatedByNavigation = new HashSet<AbsenceType>();
            AbsenceTypeModifiedByNavigation = new HashSet<AbsenceType>();
            AirportCheckpointConfigurationCreatedByNavigation = new HashSet<AirportCheckpointConfiguration>();
            AirportCheckpointConfigurationModifiedByNavigation = new HashSet<AirportCheckpointConfiguration>();
            AirportCheckpointPassengerConfigurationCreatedByNavigation = new HashSet<AirportCheckpointPassengerConfiguration>();
            AirportCheckpointPassengerConfigurationModifiedByNavigation = new HashSet<AirportCheckpointPassengerConfiguration>();
            AirportCheckpointStaffConfigurationCreatedByNavigation = new HashSet<AirportCheckpointStaffConfiguration>();
            AirportCheckpointStaffConfigurationModifiedByNavigation = new HashSet<AirportCheckpointStaffConfiguration>();
            AirportCheckpointTypeCreatedByNavigation = new HashSet<AirportCheckpointType>();
            AirportCheckpointTypeModifiedByNavigation = new HashSet<AirportCheckpointType>();
            AirportConfigurationCreatedByNavigation = new HashSet<AirportConfiguration>();
            AirportConfigurationModifiedByNavigation = new HashSet<AirportConfiguration>();
            AirportConfigurationEmployeeCreatedByNavigation = new HashSet<AirportConfigurationEmployee>();
            AirportConfigurationEmployeeModifiedByNavigation = new HashSet<AirportConfigurationEmployee>();
            AirportPlanningUnitParameterConfigurationCreatedByNavigation = new HashSet<AirportPlanningUnitParameterConfiguration>();
            AirportPlanningUnitParameterConfigurationModifiedByNavigation = new HashSet<AirportPlanningUnitParameterConfiguration>();
            AirportPrognosisImportDataCreatedByNavigation = new HashSet<AirportPrognosisImportData>();
            AirportPrognosisImportDataModifiedByNavigation = new HashSet<AirportPrognosisImportData>();
            AirportPrognosisImportDatasetCreatedByNavigation = new HashSet<AirportPrognosisImportDataset>();
            AirportPrognosisImportDatasetModifiedByNavigation = new HashSet<AirportPrognosisImportDataset>();
            AirportRequirementFileTypeCreatedByNavigation = new HashSet<AirportRequirementFileType>();
            AirportRequirementFileTypeModifiedByNavigation = new HashSet<AirportRequirementFileType>();
            AirportRequirementTypeCreatedByNavigation = new HashSet<AirportRequirementType>();
            AirportRequirementTypeModifiedByNavigation = new HashSet<AirportRequirementType>();
            AirportStaffingContractHeadCreatedByNavigation = new HashSet<AirportStaffingContractHead>();
            AirportStaffingContractHeadModifiedByNavigation = new HashSet<AirportStaffingContractHead>();
            AirportStaffingContractRuleCreatedByNavigation = new HashSet<AirportStaffingContractRule>();
            AirportStaffingContractRuleModifiedByNavigation = new HashSet<AirportStaffingContractRule>();
            AirportStaffingPlanningUnitParameterCreatedByNavigation = new HashSet<AirportStaffingPlanningUnitParameter>();
            AirportStaffingPlanningUnitParameterModifiedByNavigation = new HashSet<AirportStaffingPlanningUnitParameter>();
            AirportStaffingPrognosisCreatedByNavigation = new HashSet<AirportStaffingPrognosis>();
            AirportStaffingPrognosisModifiedByNavigation = new HashSet<AirportStaffingPrognosis>();
            AirportStaffingPrognosisBookingCreatedByNavigation = new HashSet<AirportStaffingPrognosisBooking>();
            AirportStaffingPrognosisBookingModifiedByNavigation = new HashSet<AirportStaffingPrognosisBooking>();
            AirportStaffingPrognosisEmployeeCreatedByNavigation = new HashSet<AirportStaffingPrognosisEmployee>();
            AirportStaffingPrognosisEmployeeModifiedByNavigation = new HashSet<AirportStaffingPrognosisEmployee>();
            AirportStaffingPrognosisParameterCreatedByNavigation = new HashSet<AirportStaffingPrognosisParameter>();
            AirportStaffingPrognosisParameterModifiedByNavigation = new HashSet<AirportStaffingPrognosisParameter>();
            AirportStaffingStaffCreatedByNavigation = new HashSet<AirportStaffingStaff>();
            AirportStaffingStaffModifiedByNavigation = new HashSet<AirportStaffingStaff>();
            AirportTerminalConfigurationCreatedByNavigation = new HashSet<AirportTerminalConfiguration>();
            AirportTerminalConfigurationModifiedByNavigation = new HashSet<AirportTerminalConfiguration>();
            AllowedEmploymentCategoryAbsenceTypeCreatedByNavigation = new HashSet<AllowedEmploymentCategoryAbsenceType>();
            AllowedEmploymentCategoryAbsenceTypeModifiedByNavigation = new HashSet<AllowedEmploymentCategoryAbsenceType>();
            ApplicationPartCreatedByNavigation = new HashSet<ApplicationPart>();
            ApplicationPartModifiedByNavigation = new HashSet<ApplicationPart>();
            ApprovalCreatedByNavigation = new HashSet<Approval>();
            ApprovalModifiedByNavigation = new HashSet<Approval>();
            BookingDeletionReason = new HashSet<BookingDeletionReason>();
            BookingSalarySupplementCreatedByNavigation = new HashSet<BookingSalarySupplement>();
            BookingSalarySupplementModifiedByNavigation = new HashSet<BookingSalarySupplement>();
            BookingTypeCreatedByNavigation = new HashSet<BookingType>();
            BookingTypeModifiedByNavigation = new HashSet<BookingType>();
            DayTypeCreatedByNavigation = new HashSet<DayType>();
            DayTypeModifiedByNavigation = new HashSet<DayType>();
            DaytypePlanningUnitShift = new HashSet<DaytypePlanningUnitShift>();
            DaytypeRulePlanningUnitShift = new HashSet<DaytypeRulePlanningUnitShift>();
            EmployeeApprovalCreatedByNavigation = new HashSet<EmployeeApproval>();
            EmployeeApprovalModifiedByNavigation = new HashSet<EmployeeApproval>();
            EmployeeDateIntervalCreatedByNavigation = new HashSet<EmployeeDateInterval>();
            EmployeeDateIntervalModifiedByNavigation = new HashSet<EmployeeDateInterval>();
            EmployeeFictiveSchedulingDataCreatedByNavigation = new HashSet<EmployeeFictiveSchedulingData>();
            EmployeeFictiveSchedulingDataModifiedByNavigation = new HashSet<EmployeeFictiveSchedulingData>();
            EmployeeImageCreatedByNavigation = new HashSet<EmployeeImage>();
            EmployeeImageModifiedByNavigation = new HashSet<EmployeeImage>();
            EmployeeMonthSalarySupplementCreatedByNavigation = new HashSet<EmployeeMonthSalarySupplement>();
            EmployeeMonthSalarySupplementModifiedByNavigation = new HashSet<EmployeeMonthSalarySupplement>();
            EmployeeNoteCreatedByNavigation = new HashSet<EmployeeNote>();
            EmployeeNoteModifiedByNavigation = new HashSet<EmployeeNote>();
            EmployeePlanningUnitExperience = new HashSet<EmployeePlanningUnitExperience>();
            EmployeeQualificationCreatedByNavigation = new HashSet<EmployeeQualification>();
            EmployeeQualificationModifiedByNavigation = new HashSet<EmployeeQualification>();
            EmployeeSalarySupplementCreatedByNavigation = new HashSet<EmployeeSalarySupplement>();
            EmployeeSalarySupplementModifiedByNavigation = new HashSet<EmployeeSalarySupplement>();
            EmployeeSkillCreatedByNavigation = new HashSet<EmployeeSkill>();
            EmployeeSkillModifiedByNavigation = new HashSet<EmployeeSkill>();
            EmployeeUnionTrusteeCreatedByNavigation = new HashSet<EmployeeUnionTrustee>();
            EmployeeUnionTrusteeModifiedByNavigation = new HashSet<EmployeeUnionTrustee>();
            EmploymentCreatedByNavigation = new HashSet<Employment>();
            EmploymentModifiedByNavigation = new HashSet<Employment>();
            EmploymentCategoryCreatedByNavigation = new HashSet<EmploymentCategory>();
            EmploymentCategoryModifiedByNavigation = new HashSet<EmploymentCategory>();
            EmploymentHoursGuaranteedCreatedByNavigation = new HashSet<EmploymentHoursGuaranteed>();
            EmploymentHoursGuaranteedModifiedByNavigation = new HashSet<EmploymentHoursGuaranteed>();
            EntityCreatedByNavigation = new HashSet<Entity>();
            EntityModifiedByNavigation = new HashSet<Entity>();
            EventLogCreatedByNavigation = new HashSet<EventLog>();
            EventLogModifiedByNavigation = new HashSet<EventLog>();
            FictiveSchedulingDataCreatedByNavigation = new HashSet<FictiveSchedulingData>();
            FictiveSchedulingDataModifiedByNavigation = new HashSet<FictiveSchedulingData>();
            FictiveSchedulingShiftCreatedByNavigation = new HashSet<FictiveSchedulingShift>();
            FictiveSchedulingShiftModifiedByNavigation = new HashSet<FictiveSchedulingShift>();
            FictiveSchedulingShiftTypeCreatedByNavigation = new HashSet<FictiveSchedulingShiftType>();
            FictiveSchedulingShiftTypeModifiedByNavigation = new HashSet<FictiveSchedulingShiftType>();
            FictiveSchedulingShiftTypeHourCreatedByNavigation = new HashSet<FictiveSchedulingShiftTypeHour>();
            FictiveSchedulingShiftTypeHourModifiedByNavigation = new HashSet<FictiveSchedulingShiftTypeHour>();
            InconvenientHourCalendarCreatedByNavigation = new HashSet<InconvenientHourCalendar>();
            InconvenientHourCalendarModifiedByNavigation = new HashSet<InconvenientHourCalendar>();
            InconvenientHourRankCreatedByNavigation = new HashSet<InconvenientHourRank>();
            InconvenientHourRankModifiedByNavigation = new HashSet<InconvenientHourRank>();
            JobDefinitionCreatedByNavigation = new HashSet<JobDefinition>();
            JobDefinitionModifiedByNavigation = new HashSet<JobDefinition>();
            JobLogItemCreatedByNavigation = new HashSet<JobLogItem>();
            JobLogItemModifiedByNavigation = new HashSet<JobLogItem>();
            JobRunCreatedByNavigation = new HashSet<JobRun>();
            JobRunModifiedByNavigation = new HashSet<JobRun>();
            JobTypeCreatedByNavigation = new HashSet<JobType>();
            JobTypeModifiedByNavigation = new HashSet<JobType>();
            PlanningGroupGenderConstraintCreatedByNavigation = new HashSet<PlanningGroupGenderConstraint>();
            PlanningGroupGenderConstraintModifiedByNavigation = new HashSet<PlanningGroupGenderConstraint>();
            PlanningGroupPlanningUnitCreatedByNavigation = new HashSet<PlanningGroupPlanningUnit>();
            PlanningGroupPlanningUnitModifiedByNavigation = new HashSet<PlanningGroupPlanningUnit>();
            PlanningPeriodCreatedByNavigation = new HashSet<PlanningPeriod>();
            PlanningPeriodModifiedByNavigation = new HashSet<PlanningPeriod>();
            PlanningUnitCreatedByNavigation = new HashSet<PlanningUnit>();
            PlanningUnitModifiedByNavigation = new HashSet<PlanningUnit>();
            PlanningUnitApprovalCreatedByNavigation = new HashSet<PlanningUnitApproval>();
            PlanningUnitApprovalModifiedByNavigation = new HashSet<PlanningUnitApproval>();
            PlanningUnitCostCreatedByNavigation = new HashSet<PlanningUnitCost>();
            PlanningUnitCostModifiedByNavigation = new HashSet<PlanningUnitCost>();
            PlanningUnitNoteCreatedByNavigation = new HashSet<PlanningUnitNote>();
            PlanningUnitNoteModifiedByNavigation = new HashSet<PlanningUnitNote>();
            PlanningUnitQualificationCreatedByNavigation = new HashSet<PlanningUnitQualification>();
            PlanningUnitQualificationModifiedByNavigation = new HashSet<PlanningUnitQualification>();
            PlanningUnitSalarySupplementCreatedByNavigation = new HashSet<PlanningUnitSalarySupplement>();
            PlanningUnitSalarySupplementModifiedByNavigation = new HashSet<PlanningUnitSalarySupplement>();
            PlanningUnitShiftCreatedByNavigation = new HashSet<PlanningUnitShift>();
            PlanningUnitShiftModifiedByNavigation = new HashSet<PlanningUnitShift>();
            PlanningUnitShiftBreakCreatedByNavigation = new HashSet<PlanningUnitShiftBreak>();
            PlanningUnitShiftBreakModifiedByNavigation = new HashSet<PlanningUnitShiftBreak>();
            PlanningUnitSkill = new HashSet<PlanningUnitSkill>();
            PlanningUnitSpecificationCreatedByNavigation = new HashSet<PlanningUnitSpecification>();
            PlanningUnitSpecificationModifiedByNavigation = new HashSet<PlanningUnitSpecification>();
            PlanningUnitSpecificationDayTypeCreatedByNavigation = new HashSet<PlanningUnitSpecificationDayType>();
            PlanningUnitSpecificationDayTypeModifiedByNavigation = new HashSet<PlanningUnitSpecificationDayType>();
            PlanningUnitSpecificationDayTypeValueCreatedByNavigation = new HashSet<PlanningUnitSpecificationDayTypeValue>();
            PlanningUnitSpecificationDayTypeValueModifiedByNavigation = new HashSet<PlanningUnitSpecificationDayTypeValue>();
            PlanningUnitTypeCreatedByNavigation = new HashSet<PlanningUnitType>();
            PlanningUnitTypeModifiedByNavigation = new HashSet<PlanningUnitType>();
            PlanningUnitTypeSalarySupplementCreatedByNavigation = new HashSet<PlanningUnitTypeSalarySupplement>();
            PlanningUnitTypeSalarySupplementModifiedByNavigation = new HashSet<PlanningUnitTypeSalarySupplement>();
            PlanningUnitVersionCreatedByNavigation = new HashSet<PlanningUnitVersion>();
            PlanningUnitVersionModifiedByNavigation = new HashSet<PlanningUnitVersion>();
            PreFilter = new HashSet<PreFilter>();
            ProductCreatedByNavigation = new HashSet<Product>();
            ProductModifiedByNavigation = new HashSet<Product>();
            ProductSalarySupplementCreatedByNavigation = new HashSet<ProductSalarySupplement>();
            ProductSalarySupplementModifiedByNavigation = new HashSet<ProductSalarySupplement>();
            ProfitCenterCreatedByNavigation = new HashSet<ProfitCenter>();
            ProfitCenterModifiedByNavigation = new HashSet<ProfitCenter>();
            ProfitCenterRightCreatedByNavigation = new HashSet<ProfitCenterRight>();
            ProfitCenterRightModifiedByNavigation = new HashSet<ProfitCenterRight>();
            ProfitCenterRightSystemUser = new HashSet<ProfitCenterRight>();
            QualificationCreatedByNavigation = new HashSet<Qualification>();
            QualificationModifiedByNavigation = new HashSet<Qualification>();
            SalaryRun = new HashSet<SalaryRun>();
            SalarySupplementCreatedByNavigation = new HashSet<SalarySupplement>();
            SalarySupplementModifiedByNavigation = new HashSet<SalarySupplement>();
            SchedulingDataCreatedByNavigation = new HashSet<SchedulingData>();
            SchedulingDataModifiedByNavigation = new HashSet<SchedulingData>();
            SchedulingDataCycleCreatedByNavigation = new HashSet<SchedulingDataCycle>();
            SchedulingDataCycleModifiedByNavigation = new HashSet<SchedulingDataCycle>();
            SchedulingDataCycleRowCreatedByNavigation = new HashSet<SchedulingDataCycleRow>();
            SchedulingDataCycleRowModifiedByNavigation = new HashSet<SchedulingDataCycleRow>();
            SchedulingDataRolloutHistoryCreatedByNavigation = new HashSet<SchedulingDataRolloutHistory>();
            SchedulingDataRolloutHistoryModifiedByNavigation = new HashSet<SchedulingDataRolloutHistory>();
            SchedulingDataScheduleRowCreatedByNavigation = new HashSet<SchedulingDataScheduleRow>();
            SchedulingDataScheduleRowModifiedByNavigation = new HashSet<SchedulingDataScheduleRow>();
            SchedulingDataShiftCreatedByNavigation = new HashSet<SchedulingDataShift>();
            SchedulingDataShiftModifiedByNavigation = new HashSet<SchedulingDataShift>();
            SchedulingDataVersionCreatedByNavigation = new HashSet<SchedulingDataVersion>();
            SchedulingDataVersionModifiedByNavigation = new HashSet<SchedulingDataVersion>();
            SchedulingDataVersionEmployeeCreatedByNavigation = new HashSet<SchedulingDataVersionEmployee>();
            SchedulingDataVersionEmployeeModifiedByNavigation = new HashSet<SchedulingDataVersionEmployee>();
            SecurityRoleCreatedByNavigation = new HashSet<SecurityRole>();
            SecurityRoleModifiedByNavigation = new HashSet<SecurityRole>();
            SecurityRoleAppPartDataCreatedByNavigation = new HashSet<SecurityRoleAppPartData>();
            SecurityRoleAppPartDataModifiedByNavigation = new HashSet<SecurityRoleAppPartData>();
            SecurityRoleEntityDataCreatedByNavigation = new HashSet<SecurityRoleEntityData>();
            SecurityRoleEntityDataModifiedByNavigation = new HashSet<SecurityRoleEntityData>();
            SkillCreatedByNavigation = new HashSet<Skill>();
            SkillModifiedByNavigation = new HashSet<Skill>();
            SmsListCreatedByNavigation = new HashSet<SmsList>();
            SmsListModifiedByNavigation = new HashSet<SmsList>();
            SmsListRowCreatedByNavigation = new HashSet<SmsListRow>();
            SmsListRowModifiedByNavigation = new HashSet<SmsListRow>();
            SmsLog = new HashSet<SmsLog>();
            Union = new HashSet<Union>();
            VacancyCodeCreatedByNavigation = new HashSet<VacancyCode>();
            VacancyCodeModifiedByNavigation = new HashSet<VacancyCode>();
            VacancyPlanningSimulationCreatedByNavigation = new HashSet<VacancyPlanningSimulation>();
            VacancyPlanningSimulationModifiedByNavigation = new HashSet<VacancyPlanningSimulation>();
            WeekScheduleFilterCreatedByNavigation = new HashSet<WeekScheduleFilter>();
            WeekScheduleFilterModifiedByNavigation = new HashSet<WeekScheduleFilter>();
            WeekScheduleFilterSystemUser = new HashSet<WeekScheduleFilter>();
            WorkContract = new HashSet<WorkContract>();
            WorkContractRule = new HashSet<WorkContractRule>();
            WorkScheduleChangeSet = new HashSet<WorkScheduleChangeSet>();
        }

        public int SystemUserId { get; set; }
        public int? EmployeeId { get; set; }
        public int? SecurityRoleId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int? LanguageId { get; set; }
        public int WeekScheduleLoadSize { get; set; }
        public string GridViewsSettingsXml { get; set; }
        public string DashboardSettingsXml { get; set; }
        public bool SearchPeriodIsMonth { get; set; }
        public bool PartTimeAbsenceIsPlanned { get; set; }
        public bool HasGspTraining { get; set; }
        public int? SystemUserFunctionId { get; set; }
        public bool? CanSearchAllUsers { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual ICollection<AbsenceType> AbsenceTypeCreatedByNavigation { get; set; }
        public virtual ICollection<AbsenceType> AbsenceTypeModifiedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointConfiguration> AirportCheckpointConfigurationCreatedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointConfiguration> AirportCheckpointConfigurationModifiedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointPassengerConfiguration> AirportCheckpointPassengerConfigurationCreatedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointPassengerConfiguration> AirportCheckpointPassengerConfigurationModifiedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointStaffConfiguration> AirportCheckpointStaffConfigurationCreatedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointStaffConfiguration> AirportCheckpointStaffConfigurationModifiedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointType> AirportCheckpointTypeCreatedByNavigation { get; set; }
        public virtual ICollection<AirportCheckpointType> AirportCheckpointTypeModifiedByNavigation { get; set; }
        public virtual ICollection<AirportConfiguration> AirportConfigurationCreatedByNavigation { get; set; }
        public virtual ICollection<AirportConfiguration> AirportConfigurationModifiedByNavigation { get; set; }
        public virtual ICollection<AirportConfigurationEmployee> AirportConfigurationEmployeeCreatedByNavigation { get; set; }
        public virtual ICollection<AirportConfigurationEmployee> AirportConfigurationEmployeeModifiedByNavigation { get; set; }
        public virtual ICollection<AirportPlanningUnitParameterConfiguration> AirportPlanningUnitParameterConfigurationCreatedByNavigation { get; set; }
        public virtual ICollection<AirportPlanningUnitParameterConfiguration> AirportPlanningUnitParameterConfigurationModifiedByNavigation { get; set; }
        public virtual ICollection<AirportPrognosisImportData> AirportPrognosisImportDataCreatedByNavigation { get; set; }
        public virtual ICollection<AirportPrognosisImportData> AirportPrognosisImportDataModifiedByNavigation { get; set; }
        public virtual ICollection<AirportPrognosisImportDataset> AirportPrognosisImportDatasetCreatedByNavigation { get; set; }
        public virtual ICollection<AirportPrognosisImportDataset> AirportPrognosisImportDatasetModifiedByNavigation { get; set; }
        public virtual ICollection<AirportRequirementFileType> AirportRequirementFileTypeCreatedByNavigation { get; set; }
        public virtual ICollection<AirportRequirementFileType> AirportRequirementFileTypeModifiedByNavigation { get; set; }
        public virtual ICollection<AirportRequirementType> AirportRequirementTypeCreatedByNavigation { get; set; }
        public virtual ICollection<AirportRequirementType> AirportRequirementTypeModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingContractHead> AirportStaffingContractHeadCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingContractHead> AirportStaffingContractHeadModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingContractRule> AirportStaffingContractRuleCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingContractRule> AirportStaffingContractRuleModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPlanningUnitParameter> AirportStaffingPlanningUnitParameterCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPlanningUnitParameter> AirportStaffingPlanningUnitParameterModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosis> AirportStaffingPrognosisCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosis> AirportStaffingPrognosisModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosisBooking> AirportStaffingPrognosisBookingCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosisBooking> AirportStaffingPrognosisBookingModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployeeCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployeeModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosisParameter> AirportStaffingPrognosisParameterCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingPrognosisParameter> AirportStaffingPrognosisParameterModifiedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingStaff> AirportStaffingStaffCreatedByNavigation { get; set; }
        public virtual ICollection<AirportStaffingStaff> AirportStaffingStaffModifiedByNavigation { get; set; }
        public virtual ICollection<AirportTerminalConfiguration> AirportTerminalConfigurationCreatedByNavigation { get; set; }
        public virtual ICollection<AirportTerminalConfiguration> AirportTerminalConfigurationModifiedByNavigation { get; set; }
        public virtual ICollection<AllowedEmploymentCategoryAbsenceType> AllowedEmploymentCategoryAbsenceTypeCreatedByNavigation { get; set; }
        public virtual ICollection<AllowedEmploymentCategoryAbsenceType> AllowedEmploymentCategoryAbsenceTypeModifiedByNavigation { get; set; }
        public virtual ICollection<ApplicationPart> ApplicationPartCreatedByNavigation { get; set; }
        public virtual ICollection<ApplicationPart> ApplicationPartModifiedByNavigation { get; set; }
        public virtual ICollection<Approval> ApprovalCreatedByNavigation { get; set; }
        public virtual ICollection<Approval> ApprovalModifiedByNavigation { get; set; }
        public virtual ICollection<BookingDeletionReason> BookingDeletionReason { get; set; }
        public virtual ICollection<BookingSalarySupplement> BookingSalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<BookingSalarySupplement> BookingSalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<BookingType> BookingTypeCreatedByNavigation { get; set; }
        public virtual ICollection<BookingType> BookingTypeModifiedByNavigation { get; set; }
        public virtual ICollection<DayType> DayTypeCreatedByNavigation { get; set; }
        public virtual ICollection<DayType> DayTypeModifiedByNavigation { get; set; }
        public virtual ICollection<DaytypePlanningUnitShift> DaytypePlanningUnitShift { get; set; }
        public virtual ICollection<DaytypeRulePlanningUnitShift> DaytypeRulePlanningUnitShift { get; set; }
        public virtual ICollection<EmployeeApproval> EmployeeApprovalCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeApproval> EmployeeApprovalModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeDateInterval> EmployeeDateIntervalCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeDateInterval> EmployeeDateIntervalModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeFictiveSchedulingData> EmployeeFictiveSchedulingDataCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeFictiveSchedulingData> EmployeeFictiveSchedulingDataModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeImage> EmployeeImageCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeImage> EmployeeImageModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeNote> EmployeeNoteCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeNote> EmployeeNoteModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeePlanningUnitExperience> EmployeePlanningUnitExperience { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualificationCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeQualification> EmployeeQualificationModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeSalarySupplement> EmployeeSalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeSalarySupplement> EmployeeSalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkillCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkillModifiedByNavigation { get; set; }
        public virtual ICollection<EmployeeUnionTrustee> EmployeeUnionTrusteeCreatedByNavigation { get; set; }
        public virtual ICollection<EmployeeUnionTrustee> EmployeeUnionTrusteeModifiedByNavigation { get; set; }
        public virtual ICollection<Employment> EmploymentCreatedByNavigation { get; set; }
        public virtual ICollection<Employment> EmploymentModifiedByNavigation { get; set; }
        public virtual ICollection<EmploymentCategory> EmploymentCategoryCreatedByNavigation { get; set; }
        public virtual ICollection<EmploymentCategory> EmploymentCategoryModifiedByNavigation { get; set; }
        public virtual ICollection<EmploymentHoursGuaranteed> EmploymentHoursGuaranteedCreatedByNavigation { get; set; }
        public virtual ICollection<EmploymentHoursGuaranteed> EmploymentHoursGuaranteedModifiedByNavigation { get; set; }
        public virtual ICollection<Entity> EntityCreatedByNavigation { get; set; }
        public virtual ICollection<Entity> EntityModifiedByNavigation { get; set; }
        public virtual ICollection<EventLog> EventLogCreatedByNavigation { get; set; }
        public virtual ICollection<EventLog> EventLogModifiedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingData> FictiveSchedulingDataCreatedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingData> FictiveSchedulingDataModifiedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingShift> FictiveSchedulingShiftCreatedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingShift> FictiveSchedulingShiftModifiedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingShiftType> FictiveSchedulingShiftTypeCreatedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingShiftType> FictiveSchedulingShiftTypeModifiedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingShiftTypeHour> FictiveSchedulingShiftTypeHourCreatedByNavigation { get; set; }
        public virtual ICollection<FictiveSchedulingShiftTypeHour> FictiveSchedulingShiftTypeHourModifiedByNavigation { get; set; }
        public virtual ICollection<InconvenientHourCalendar> InconvenientHourCalendarCreatedByNavigation { get; set; }
        public virtual ICollection<InconvenientHourCalendar> InconvenientHourCalendarModifiedByNavigation { get; set; }
        public virtual ICollection<InconvenientHourRank> InconvenientHourRankCreatedByNavigation { get; set; }
        public virtual ICollection<InconvenientHourRank> InconvenientHourRankModifiedByNavigation { get; set; }
        public virtual ICollection<JobDefinition> JobDefinitionCreatedByNavigation { get; set; }
        public virtual ICollection<JobDefinition> JobDefinitionModifiedByNavigation { get; set; }
        public virtual ICollection<JobLogItem> JobLogItemCreatedByNavigation { get; set; }
        public virtual ICollection<JobLogItem> JobLogItemModifiedByNavigation { get; set; }
        public virtual ICollection<JobRun> JobRunCreatedByNavigation { get; set; }
        public virtual ICollection<JobRun> JobRunModifiedByNavigation { get; set; }
        public virtual ICollection<JobType> JobTypeCreatedByNavigation { get; set; }
        public virtual ICollection<JobType> JobTypeModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningGroupGenderConstraint> PlanningGroupGenderConstraintCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningGroupGenderConstraint> PlanningGroupGenderConstraintModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningGroupPlanningUnit> PlanningGroupPlanningUnitCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningGroupPlanningUnit> PlanningGroupPlanningUnitModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningPeriod> PlanningPeriodCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningPeriod> PlanningPeriodModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnit> PlanningUnitCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnit> PlanningUnitModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitApproval> PlanningUnitApprovalCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitApproval> PlanningUnitApprovalModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitCost> PlanningUnitCostCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitCost> PlanningUnitCostModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitNote> PlanningUnitNoteCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitNote> PlanningUnitNoteModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitQualification> PlanningUnitQualificationCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitQualification> PlanningUnitQualificationModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSalarySupplement> PlanningUnitSalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSalarySupplement> PlanningUnitSalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitShift> PlanningUnitShiftCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitShift> PlanningUnitShiftModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitShiftBreak> PlanningUnitShiftBreakCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitShiftBreak> PlanningUnitShiftBreakModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSkill> PlanningUnitSkill { get; set; }
        public virtual ICollection<PlanningUnitSpecification> PlanningUnitSpecificationCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSpecification> PlanningUnitSpecificationModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSpecificationDayType> PlanningUnitSpecificationDayTypeCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSpecificationDayType> PlanningUnitSpecificationDayTypeModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSpecificationDayTypeValue> PlanningUnitSpecificationDayTypeValueCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitSpecificationDayTypeValue> PlanningUnitSpecificationDayTypeValueModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitType> PlanningUnitTypeCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitType> PlanningUnitTypeModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitTypeSalarySupplement> PlanningUnitTypeSalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitTypeSalarySupplement> PlanningUnitTypeSalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitVersion> PlanningUnitVersionCreatedByNavigation { get; set; }
        public virtual ICollection<PlanningUnitVersion> PlanningUnitVersionModifiedByNavigation { get; set; }
        public virtual ICollection<PreFilter> PreFilter { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductModifiedByNavigation { get; set; }
        public virtual ICollection<ProductSalarySupplement> ProductSalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<ProductSalarySupplement> ProductSalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<ProfitCenter> ProfitCenterCreatedByNavigation { get; set; }
        public virtual ICollection<ProfitCenter> ProfitCenterModifiedByNavigation { get; set; }
        public virtual ICollection<ProfitCenterRight> ProfitCenterRightCreatedByNavigation { get; set; }
        public virtual ICollection<ProfitCenterRight> ProfitCenterRightModifiedByNavigation { get; set; }
        public virtual ICollection<ProfitCenterRight> ProfitCenterRightSystemUser { get; set; }
        public virtual ICollection<Qualification> QualificationCreatedByNavigation { get; set; }
        public virtual ICollection<Qualification> QualificationModifiedByNavigation { get; set; }
        public virtual ICollection<SalaryRun> SalaryRun { get; set; }
        public virtual ICollection<SalarySupplement> SalarySupplementCreatedByNavigation { get; set; }
        public virtual ICollection<SalarySupplement> SalarySupplementModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingData> SchedulingDataCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingData> SchedulingDataModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataCycle> SchedulingDataCycleCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataCycle> SchedulingDataCycleModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataCycleRow> SchedulingDataCycleRowCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataCycleRow> SchedulingDataCycleRowModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataRolloutHistory> SchedulingDataRolloutHistoryCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataRolloutHistory> SchedulingDataRolloutHistoryModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataScheduleRow> SchedulingDataScheduleRowCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataScheduleRow> SchedulingDataScheduleRowModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataShift> SchedulingDataShiftCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataShift> SchedulingDataShiftModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataVersion> SchedulingDataVersionCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataVersion> SchedulingDataVersionModifiedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataVersionEmployee> SchedulingDataVersionEmployeeCreatedByNavigation { get; set; }
        public virtual ICollection<SchedulingDataVersionEmployee> SchedulingDataVersionEmployeeModifiedByNavigation { get; set; }
        public virtual ICollection<SecurityRole> SecurityRoleCreatedByNavigation { get; set; }
        public virtual ICollection<SecurityRole> SecurityRoleModifiedByNavigation { get; set; }
        public virtual ICollection<SecurityRoleAppPartData> SecurityRoleAppPartDataCreatedByNavigation { get; set; }
        public virtual ICollection<SecurityRoleAppPartData> SecurityRoleAppPartDataModifiedByNavigation { get; set; }
        public virtual ICollection<SecurityRoleEntityData> SecurityRoleEntityDataCreatedByNavigation { get; set; }
        public virtual ICollection<SecurityRoleEntityData> SecurityRoleEntityDataModifiedByNavigation { get; set; }
        public virtual ICollection<Skill> SkillCreatedByNavigation { get; set; }
        public virtual ICollection<Skill> SkillModifiedByNavigation { get; set; }
        public virtual ICollection<SmsList> SmsListCreatedByNavigation { get; set; }
        public virtual ICollection<SmsList> SmsListModifiedByNavigation { get; set; }
        public virtual ICollection<SmsListRow> SmsListRowCreatedByNavigation { get; set; }
        public virtual ICollection<SmsListRow> SmsListRowModifiedByNavigation { get; set; }
        public virtual ICollection<SmsLog> SmsLog { get; set; }
        public virtual ICollection<Union> Union { get; set; }
        public virtual ICollection<VacancyCode> VacancyCodeCreatedByNavigation { get; set; }
        public virtual ICollection<VacancyCode> VacancyCodeModifiedByNavigation { get; set; }
        public virtual ICollection<VacancyPlanningSimulation> VacancyPlanningSimulationCreatedByNavigation { get; set; }
        public virtual ICollection<VacancyPlanningSimulation> VacancyPlanningSimulationModifiedByNavigation { get; set; }
        public virtual ICollection<WeekScheduleFilter> WeekScheduleFilterCreatedByNavigation { get; set; }
        public virtual ICollection<WeekScheduleFilter> WeekScheduleFilterModifiedByNavigation { get; set; }
        public virtual ICollection<WeekScheduleFilter> WeekScheduleFilterSystemUser { get; set; }
        public virtual ICollection<WorkContract> WorkContract { get; set; }
        public virtual ICollection<WorkContractRule> WorkContractRule { get; set; }
        public virtual ICollection<WorkScheduleChangeSet> WorkScheduleChangeSet { get; set; }
    }
}
