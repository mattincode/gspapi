using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace gspApi.Models
{
    public partial class GSPSeRef160613Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=securitassql;Database=GSPSeRef160613;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbsenceType>(entity =>
            {
                entity.Property(e => e.AbsenceTypeId).ValueGeneratedNever();

                entity.Property(e => e.AbsenceWorkAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.AllowNotGranted).HasDefaultValueSql("0");

                entity.Property(e => e.AllowedPercentages).HasColumnType("varchar(100)");

                entity.Property(e => e.ControlIntervalDays).HasColumnType("varchar(50)");

                entity.Property(e => e.CountsAsWorkTime).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.CreatesAbsenceBookings).HasDefaultValueSql("1");

                entity.Property(e => e.ImportedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasColumnType("Name");

                entity.Property(e => e.ReducedWorkHours).HasDefaultValueSql("0");

                entity.Property(e => e.ResultsInOvertime).HasDefaultValueSql("1");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'X'");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AbsenceTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AbsenceType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AbsenceTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AbsenceType_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportCheckpointConfiguration>(entity =>
            {
                entity.Property(e => e.AirportCheckpointConfigurationId).ValueGeneratedOnAdd();

                entity.Property(e => e.CheckpointTypeId).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AirportCheckpointConfigurationNavigation)
                    .WithOne(p => p.InverseAirportCheckpointConfigurationNavigation)
                    .HasForeignKey<AirportCheckpointConfiguration>(d => d.AirportCheckpointConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointConfiguration_DependsOnCheckpoint");

                entity.HasOne(d => d.AirportTerminalConfiguration)
                    .WithMany(p => p.AirportCheckpointConfiguration)
                    .HasForeignKey(d => d.AirportTerminalConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointConfiguration_AirportTerminalConfigurationId");

                entity.HasOne(d => d.CheckpointType)
                    .WithMany(p => p.AirportCheckpointConfiguration)
                    .HasForeignKey(d => d.CheckpointTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointConfiguration_CheckpointType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportCheckpointConfigurationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointConfiguration_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportCheckpointConfigurationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointConfiguration_ModifiedBy_User");

                entity.HasOne(d => d.PlanningGroup)
                    .WithMany(p => p.AirportCheckpointConfiguration)
                    .HasForeignKey(d => d.PlanningGroupId)
                    .HasConstraintName("FK_AirportCheckpointConfiguration_PlanningGroupId");
            });

            modelBuilder.Entity<AirportCheckpointPassengerConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportCheckpointConfiguration)
                    .WithMany(p => p.AirportCheckpointPassengerConfiguration)
                    .HasForeignKey(d => d.AirportCheckpointConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointPassengerConfiguration_AirportCheckpointConfigurationId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportCheckpointPassengerConfigurationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointPassengerConfiguration_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportCheckpointPassengerConfigurationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointPassengerConfiguration_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportCheckpointStaffConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportCheckpointPassengerConfiguration)
                    .WithMany(p => p.AirportCheckpointStaffConfiguration)
                    .HasForeignKey(d => d.AirportCheckpointPassengerConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointStaffConfiguration_AirportCheckpointPassengerConfigurationId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportCheckpointStaffConfigurationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointStaffConfiguration_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportCheckpointStaffConfigurationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointStaffConfiguration_ModifiedBy_User");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.AirportCheckpointStaffConfiguration)
                    .HasForeignKey(d => d.QualificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointStaffConfiguration_QualificationId");
            });

            modelBuilder.Entity<AirportCheckpointType>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportCheckpointTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportCheckpointTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportCheckpointType_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportConfigurationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportConfiguration_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportConfigurationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportConfiguration_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportConfigurationEmployee>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportConfiguration)
                    .WithMany(p => p.AirportConfigurationEmployee)
                    .HasForeignKey(d => d.AirportConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportConfigurationEmployee_AirportConfiguration");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportConfigurationEmployeeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportConfigurationEmployee_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AirportConfigurationEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportConfigurationEmployee_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportConfigurationEmployeeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportConfigurationEmployee_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportPlanningUnitParameterConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Value).HasColumnType("decimal");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportPlanningUnitParameterConfigurationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPlanningUnitParameterConfiguration_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportPlanningUnitParameterConfigurationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPlanningUnitParameterConfiguration_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportPrognosisImportData>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportPrognosisImportDataset)
                    .WithMany(p => p.AirportPrognosisImportData)
                    .HasForeignKey(d => d.AirportPrognosisImportDatasetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportData_AirportPrognosisImportDatasetId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportPrognosisImportDataCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportData_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportPrognosisImportDataModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportData_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportPrognosisImportDataset>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportRequirementType)
                    .WithMany(p => p.AirportPrognosisImportDataset)
                    .HasForeignKey(d => d.AirportRequirementTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportDataset_AirportRequirementTypeId");

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportPrognosisImportDataset)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportDataset_AirportStaffingPrognosisId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportPrognosisImportDatasetCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportDataset_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportPrognosisImportDatasetModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportPrognosisImportDataset_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportRequirementFileType>(entity =>
            {
                entity.Property(e => e.AssemblyName).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Filetypes).HasColumnType("nchar(50)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AirportRequirementType)
                    .WithMany(p => p.AirportRequirementFileType)
                    .HasForeignKey(d => d.AirportRequirementTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportRequirementFileType_AirportRequirementTypeId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportRequirementFileTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportRequirementFileType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportRequirementFileTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportRequirementFileType_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportRequirementType>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportRequirementTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportRequirementType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportRequirementTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportRequirementType_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportStaffingContractHead>(entity =>
            {
                entity.Property(e => e.ContractName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportStaffingContractHead)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractHead_AirportStaffingPrognosis");

                entity.HasOne(d => d.AirportTerminalConfiguration)
                    .WithMany(p => p.AirportStaffingContractHead)
                    .HasForeignKey(d => d.AirportTerminalConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractHead_AirportTerminalConfiguration");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingContractHeadCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractHead_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingContractHeadModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractHead_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportStaffingContractRule>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.NewValue).HasColumnType("decimal");

                entity.Property(e => e.OrgValue).HasColumnType("decimal");

                entity.Property(e => e.Rule)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.AirportStaffingContractHead)
                    .WithMany(p => p.AirportStaffingContractRule)
                    .HasForeignKey(d => d.AirportStaffingContractHeadId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractRule_AirportStaffingContractHead");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingContractRuleCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractRule_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingContractRuleModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingContractRule_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportStaffingPlanningUnitParameter>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.NewValue).HasColumnType("decimal");

                entity.Property(e => e.OrgValue).HasColumnType("decimal");

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportStaffingPlanningUnitParameter)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPlanningUnitParameter_AirportStaffingPrognosis");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingPlanningUnitParameterCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPlanningUnitParameter_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingPlanningUnitParameterModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPlanningUnitParameter_ModifiedBy_User");

                entity.HasOne(d => d.ParameterNavigation)
                    .WithMany(p => p.AirportStaffingPlanningUnitParameter)
                    .HasForeignKey(d => d.Parameter)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPlanningUnitParameter_AirportPlanningUnitParameterConfiguration");
            });

            modelBuilder.Entity<AirportStaffingPrognosis>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StaffingData).HasColumnType("xml");

                entity.Property(e => e.StaffingDataOnImport).HasColumnType("xml");

                entity.Property(e => e.State).HasDefaultValueSql("0");

                entity.HasOne(d => d.AirportConfiguration)
                    .WithMany(p => p.AirportStaffingPrognosis)
                    .HasForeignKey(d => d.AirportConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosis_AirportConfigurationId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosis_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosis_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportStaffingPrognosisBooking>(entity =>
            {
                entity.Property(e => e.AbsenceTypeName).HasColumnType("Name");

                entity.Property(e => e.BookingTypeName).HasColumnType("Name");

                entity.Property(e => e.BookingTypeShortName).HasMaxLength(5);

                entity.Property(e => e.BreakXml).HasColumnType("xml");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DataType).HasDefaultValueSql("1");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.PlanningUnitNumber).HasColumnType("varchar(4)");

                entity.Property(e => e.ProfitCenterNumber).HasMaxLength(10);

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.AirportStaffingPrognosisEmployee)
                    .WithMany(p => p.AirportStaffingPrognosisBooking)
                    .HasForeignKey(d => d.AirportStaffingPrognosisEmployeeId)
                    .HasConstraintName("FK_AirportStaffingPrognosisBooking_AirportStaffingPrognosisEmployeeId");

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportStaffingPrognosisBooking)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisBooking_AirportStaffingPrognosisId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisBookingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisBooking_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisBookingModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisBooking_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportStaffingPrognosisEmployee>(entity =>
            {
                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DataType).HasDefaultValueSql("1");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IsFakeUser).HasDefaultValueSql("0");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportStaffingPrognosisEmployee)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisEmployee_AirportStaffingPrognosisId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisEmployeeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisEmployee_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AirportStaffingPrognosisEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_AirportStaffingPrognosisEmployee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisEmployeeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisEmployee_ModifiedBy_User");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.AirportStaffingPrognosisEmployee)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisEmployee_ProfitCenterId");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.AirportStaffingPrognosisEmployee)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_AirportStaffingPrognosisEmployee_QualificationId");
            });

            modelBuilder.Entity<AirportStaffingPrognosisParameter>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Value).HasColumnType("numeric");

                entity.HasOne(d => d.AirportCheckpointConfiguration)
                    .WithMany(p => p.AirportStaffingPrognosisParameter)
                    .HasForeignKey(d => d.AirportCheckpointConfigurationId)
                    .HasConstraintName("FK_AirportStaffingPrognosisParameter_AirportCheckpointConfigurationId");

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportStaffingPrognosisParameter)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisParameter_AirportStaffingPrognosisId");

                entity.HasOne(d => d.AirportTerminalConfiguration)
                    .WithMany(p => p.AirportStaffingPrognosisParameter)
                    .HasForeignKey(d => d.AirportTerminalConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisParameter_AirportTerminalConfigurationId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisParameterCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisParameter_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingPrognosisParameterModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingPrognosisParameter_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportStaffingStaff>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.AirportStaffingPrognosis)
                    .WithMany(p => p.AirportStaffingStaff)
                    .HasForeignKey(d => d.AirportStaffingPrognosisId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingStaff_AirportStaffingPrognosis");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportStaffingStaffCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingStaff_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportStaffingStaffModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportStaffingStaff_ModifiedBy_User");
            });

            modelBuilder.Entity<AirportTerminalConfiguration>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AirportConfiguration)
                    .WithMany(p => p.AirportTerminalConfiguration)
                    .HasForeignKey(d => d.AirportConfigurationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportTerminalConfiguration_AirportConfigurationId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AirportTerminalConfigurationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportTerminalConfiguration_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AirportTerminalConfigurationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AirportTerminalConfiguration_ModifiedBy_User");
            });

            modelBuilder.Entity<AllowedEmploymentCategoryAbsenceType>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.AbsenceType)
                    .WithMany(p => p.AllowedEmploymentCategoryAbsenceType)
                    .HasForeignKey(d => d.AbsenceTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AllowedEmploymentCategoryAbsenceType_AbsenceType");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AllowedEmploymentCategoryAbsenceTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AllowedEmploymentCategoryAbsenceType_CreatedBy_User");

                entity.HasOne(d => d.EmploymentCategory)
                    .WithMany(p => p.AllowedEmploymentCategoryAbsenceType)
                    .HasForeignKey(d => d.EmploymentCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AllowedEmploymentCategoryAbsenceType_EmploymentCategory");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AllowedEmploymentCategoryAbsenceTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AllowedEmploymentCategoryAbsenceType_ModifiedBy_User");
            });

            modelBuilder.Entity<ApplicationPart>(entity =>
            {
                entity.Property(e => e.ApplicationPartId).ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ApplicationPartCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationPart_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ApplicationPartModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationPart_ModifiedBy_User");
            });

            modelBuilder.Entity<ApplicationPartEntity>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationPartId, e.EntityId })
                    .HasName("PK_ApplicationPart_Entity");

                entity.ToTable("ApplicationPart_Entity");

                entity.HasOne(d => d.ApplicationPart)
                    .WithMany(p => p.ApplicationPartEntity)
                    .HasForeignKey(d => d.ApplicationPartId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationPart_Entity_ApplicationPart");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.ApplicationPartEntity)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ApplicationPart_Entity_Entity");
            });

            modelBuilder.Entity<Approval>(entity =>
            {
                entity.Property(e => e.Authority)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ApprovalCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Approval_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ApprovalModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Approval_ModifiedBy_User");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasIndex(e => e.CreatedOn)
                    .HasName("IX_Booking_CreatedOn");

                entity.HasIndex(e => new { e.BookingId, e.AbsenceTypeId })
                    .HasName("IX_Booking_AbsenceTypeId");

                entity.HasIndex(e => new { e.ChangeTraceId, e.CreatedOn })
                    .HasName("IX_BookingChangeTraceId_CreatedOn");

                entity.HasIndex(e => new { e.BookingId, e.ChangeTraceId, e.IsScheduled })
                    .HasName("ix_Booking_IsScheduled_includes");

                entity.HasIndex(e => new { e.BookingId, e.PlanningUnitId, e.BookingTypeId, e.AbsenceTypeId, e.AbsenceGranted, e.ChangeTraceId, e.CreatedBy, e.CreatedOn, e.EmployeeId, e.IsDeleted, e.StartDate, e.EndDate })
                    .HasName("IX_BookingEmpDelStartsEnds");

                entity.HasIndex(e => new { e.BookingId, e.EndDate, e.EmployeeId, e.BookingTypeId, e.AbsenceTypeId, e.AbsenceGranted, e.IsScheduled, e.IsDeleted, e.ChangeTraceId, e.CreatedBy, e.CreatedOn, e.BreakXml, e.PlanningUnitId, e.StartDate })
                    .HasName("IX_BookingPlanningUnitIdStarts");

                entity.Property(e => e.BreakXml).HasColumnType("xml");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.TimeBelongsToPreviousMonth).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BookingCache>(entity =>
            {
                entity.HasIndex(e => e.ChangeTraceId)
                    .HasName("IX_BookingCache_ChangeTraceId");

                entity.HasIndex(e => new { e.StartDate, e.EndDate })
                    .HasName("IX_BookingCache_StartDateEndDate");

                entity.HasIndex(e => new { e.EmployeeId, e.StartDate, e.EndDate, e.ScheduleType, e.BookingId })
                    .HasName("UIX_BookingCache")
                    .IsUnique();

                entity.HasIndex(e => new { e.BookingId, e.ScheduleType, e.StartDate, e.EndDate, e.ValidTo, e.ValidFrom })
                    .HasName("IX_BookingCache_ValidToValidFrom");

                entity.Property(e => e.CreatedOn).HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.Duration).HasDefaultValueSql("0");

                entity.Property(e => e.EmployeeId).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsOnFictivePlanningUnit).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedOn).HasDefaultValueSql("getutcdate()");

                entity.Property(e => e.ScheduleType).HasDefaultValueSql("0");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.TotalBreakLength).HasDefaultValueSql("0");

                entity.Property(e => e.ValidTo).HasDefaultValueSql("'2048-01-01'");

                entity.Property(e => e.Worktime).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<BookingDeletionReason>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BookingDeletionReason)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingDeletionReason_CreatedBy_User");
            });

            modelBuilder.Entity<BookingSalarySupplement>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingSalarySupplement)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingSalarySupplement_Booking");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BookingSalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingSalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BookingSalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingSalarySupplement_ModifiedBy_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BookingSalarySupplement)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingSalarySupplement_Product");

                entity.HasOne(d => d.SalarySupplement)
                    .WithMany(p => p.BookingSalarySupplement)
                    .HasForeignKey(d => d.SalarySupplementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingSalarySupplement_SalarySupplement");
            });

            modelBuilder.Entity<BookingType>(entity =>
            {
                entity.Property(e => e.BookingTypeId).ValueGeneratedNever();

                entity.Property(e => e.AllowedOnPlannedSchedule).HasDefaultValueSql("1");

                entity.Property(e => e.ConsumesVacancies).HasDefaultValueSql("1");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DoubleBookingOnEmployeeAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.DoubleBookingOnEmployeeBreakRequired).HasDefaultValueSql("0");

                entity.Property(e => e.DoubleBookingOnEmployeeRequired).HasDefaultValueSql("0");

                entity.Property(e => e.DoubleBookingOnPlanningUnitAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.DoubleBookingOnPlanningUnitRequired).HasDefaultValueSql("0");

                entity.Property(e => e.IncludedInStatutoryEducation).HasDefaultValueSql("0");

                entity.Property(e => e.IsLearningTime).HasDefaultValueSql("0");

                entity.Property(e => e.IsWorkTime).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.ShortName).HasMaxLength(5);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BookingTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BookingTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingType_ModifiedBy_User");

                entity.HasOne(d => d.WorkContract)
                    .WithMany(p => p.BookingType)
                    .HasForeignKey(d => d.WorkContractId)
                    .HasConstraintName("FK_BookingType_WorkContract");
            });

            modelBuilder.Entity<BookingsInShift>(entity =>
            {
                entity.HasKey(e => new { e.ShiftCacheId, e.BookingId })
                    .HasName("PK_BookingsInShift");

                entity.ToTable("BookingsInShift", "NonGSPCore");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingsInShift)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PK_BookingsInShift_BookingId");

                entity.HasOne(d => d.ShiftCache)
                    .WithMany(p => p.BookingsInShift)
                    .HasForeignKey(d => d.ShiftCacheId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingsInShift_ShiftId");
            });

            modelBuilder.Entity<BookingsInShiftCache>(entity =>
            {
                entity.HasKey(e => new { e.ShiftCacheId, e.BookingId })
                    .HasName("PK_BookingsInShiftCache");

                entity.HasOne(d => d.ShiftCache)
                    .WithMany(p => p.BookingsInShiftCache)
                    .HasForeignKey(d => d.ShiftCacheId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingsInShiftCache_ShiftId");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.ConfigurationId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StringValue).HasMaxLength(100);
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasIndex(e => e.ContractNumber)
                    .HasName("IX_Contract_ContractNumber");

                entity.Property(e => e.ContractId).ValueGeneratedNever();

                entity.Property(e => e.ContractNumber)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ProfitCenterNumber)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Terminate).HasColumnType("datetime");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contract_Customer");

                entity.HasOne(d => d.InvoiceAddress)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.InvoiceAddressId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Contract_InvoiceAddress");
            });

            modelBuilder.Entity<ContractPart>(entity =>
            {
                entity.Property(e => e.ContractPartId).ValueGeneratedNever();

                entity.Property(e => e.ContractPartNumber)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.ProfitCenterNumber)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractPart)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ContractPart_Contract");

                entity.HasOne(d => d.CustomerObject)
                    .WithMany(p => p.ContractPart)
                    .HasForeignKey(d => d.CustomerObjectId)
                    .HasConstraintName("FK_ContractPart_CustomerObject");

                entity.HasOne(d => d.InvoiceAddress)
                    .WithMany(p => p.ContractPart)
                    .HasForeignKey(d => d.InvoiceAddressId)
                    .HasConstraintName("FK_ContractPart_InvoiceAddress");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.CustomerNumber)
                    .HasName("IX_Customer_CustomerNumber");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Customer_Name");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.CustomerNumber)
                    .IsRequired()
                    .HasColumnType("varchar(16)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<CustomerObject>(entity =>
            {
                entity.Property(e => e.CustomerObjectId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(64)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CustomerObjectNumber)
                    .IsRequired()
                    .HasColumnType("varchar(32)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ProfitCenterNumber)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerObject)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CustomerObject_Customer");
            });

            modelBuilder.Entity<DayType>(entity =>
            {
                entity.Property(e => e.DayTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Importance).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DayTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DayType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DayTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DayType_ModifiedBy_User");
            });

            modelBuilder.Entity<DayTypeRule>(entity =>
            {
                entity.Property(e => e.Bankday).HasDefaultValueSql("0");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Holiday).HasDefaultValueSql("0");

                entity.Property(e => e.InconvenientHour).HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName).HasMaxLength(20);
            });

            modelBuilder.Entity<DayTypeRuleValue>(entity =>
            {
                entity.Property(e => e.StringValue).HasMaxLength(50);
            });

            modelBuilder.Entity<DaytypePlanningUnitShift>(entity =>
            {
                entity.HasKey(e => new { e.DayTypeId, e.PlanningUnitShiftId })
                    .HasName("PK_Daytype_PlanningUnitShift");

                entity.ToTable("Daytype_PlanningUnitShift");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DaytypePlanningUnitShift)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Daytype_PlanningUnitShift_CreatedBy_User");

                entity.HasOne(d => d.DayType)
                    .WithMany(p => p.DaytypePlanningUnitShift)
                    .HasForeignKey(d => d.DayTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DayType_PlanningUnitShift_DayType");

                entity.HasOne(d => d.PlanningUnitShift)
                    .WithMany(p => p.DaytypePlanningUnitShift)
                    .HasForeignKey(d => d.PlanningUnitShiftId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DayType_PlanningUnitShift_PlanningUnitShifts");
            });

            modelBuilder.Entity<DaytypeRulePlanningUnitShift>(entity =>
            {
                entity.HasKey(e => new { e.DayTypeRuleId, e.PlanningUnitShiftId })
                    .HasName("PK_DaytypeRule_PlanningUnitShift");

                entity.ToTable("DaytypeRule_PlanningUnitShift");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DaytypeRulePlanningUnitShift)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DaytypeRule_PlanningUnitShift_CreatedBy_User");

                entity.HasOne(d => d.DayTypeRule)
                    .WithMany(p => p.DaytypeRulePlanningUnitShift)
                    .HasForeignKey(d => d.DayTypeRuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DayTypeRule_PlanningUnitShift_DayTypeRule");

                entity.HasOne(d => d.PlanningUnitShift)
                    .WithMany(p => p.DaytypeRulePlanningUnitShift)
                    .HasForeignKey(d => d.PlanningUnitShiftId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DayTypeRule_PlanningUnitShift_PlanningUnitShifts");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.DomainName)
                    .HasName("idx_DomainName");

                entity.HasIndex(e => e.EmployeeNumber)
                    .HasName("idx_employeeNumber");

                entity.Property(e => e.AbsenceWorkAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.AddressLine3).HasMaxLength(100);

                entity.Property(e => e.Beeper).HasMaxLength(50);

                entity.Property(e => e.CareOfAddress).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.City2).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DomainName).HasMaxLength(255);

                entity.Property(e => e.DontSendToHr).HasColumnType("datetime2(0)");

                entity.Property(e => e.EmailAddress1)
                    .HasColumnName("EMailAddress1")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailAddress2)
                    .HasColumnName("EMailAddress2")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployedFrom).HasColumnType("date");

                entity.Property(e => e.EmployedTo).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MainWorkPlace).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.PersonLegalId).HasColumnType("varchar(50)");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.PostalCode2).HasMaxLength(100);

                entity.Property(e => e.PrefersPrintedSchema).HasDefaultValueSql("0");

                entity.Property(e => e.StateOrProvince).HasMaxLength(100);

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.Telephone3).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeApproval>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.Approval)
                    .WithMany(p => p.EmployeeApproval)
                    .HasForeignKey(d => d.ApprovalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Approval_Qualifications");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeApprovalCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Approval_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeApproval)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Approval_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeApprovalModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Approval_ModifiedBy_User");
            });

            modelBuilder.Entity<EmployeeDateInterval>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeDateIntervalCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDateInterval_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeDateInterval)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDateInterval_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeDateIntervalModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeDateInterval_ModifiedBy_User");
            });

            modelBuilder.Entity<EmployeeFictiveSchedulingData>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeFictiveSchedulingDataCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeFictiveSchedulingData_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeFictiveSchedulingData)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeFictiveSchedulingData_Employee");

                entity.HasOne(d => d.FictiveSchedulingData)
                    .WithMany(p => p.EmployeeFictiveSchedulingData)
                    .HasForeignKey(d => d.FictiveSchedulingDataId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeFictiveSchedulingData_FictiveSchedulingData");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeFictiveSchedulingDataModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeFictiveSchedulingData_ModifiedBy_User");
            });

            modelBuilder.Entity<EmployeeImage>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EmployeeImage1)
                    .IsRequired()
                    .HasColumnName("EmployeeImage");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeImageCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeImage_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeImage)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeImage_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeImageModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeImage_ModifiedBy_User");
            });

            modelBuilder.Entity<EmployeeMonthSalarySupplement>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeMonthSalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeMonthSalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeMonthSalarySupplement)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeMonthSalarySupplement_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeMonthSalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeMonthSalarySupplement_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.EmployeeMonthSalarySupplement)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeMonthSalarySupplement_PlanningUnit");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.EmployeeMonthSalarySupplement)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeMonthSalarySupplement_Product");

                entity.HasOne(d => d.SalarySupplement)
                    .WithMany(p => p.EmployeeMonthSalarySupplement)
                    .HasForeignKey(d => d.SalarySupplementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeMonthSalarySupplement_SalarySupplement");
            });

            modelBuilder.Entity<EmployeeNote>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeNoteCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeNote_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeNote)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeNote_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeNoteModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeNote_ModifiedBy_User");
            });

            modelBuilder.Entity<EmployeeOvertimeOverride>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeOvertimeOverride)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeOvertimeOverride_Employee");
            });

            modelBuilder.Entity<EmployeePlanningUnitExperience>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeePlanningUnitExperience)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_PlanningUnit_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePlanningUnitExperience)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_PlanningUnits_Employee");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.EmployeePlanningUnitExperience)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_PlanningUnits_PlanningUnits");
            });

            modelBuilder.Entity<EmployeeQualification>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeQualificationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Qualification_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeQualification)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Qualifications_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeQualificationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Qualification_ModifiedBy_User");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.EmployeeQualification)
                    .HasForeignKey(d => d.QualificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Qualifications_Qualifications");
            });

            modelBuilder.Entity<EmployeeSalarySupplement>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeSalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeSalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSalarySupplement)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeSalarySupplement_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeSalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeSalarySupplement_ModifiedBy_User");

                entity.HasOne(d => d.SalarySupplement)
                    .WithMany(p => p.EmployeeSalarySupplement)
                    .HasForeignKey(d => d.SalarySupplementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeSalarySupplement_SalarySupplement");
            });

            modelBuilder.Entity<EmployeeSkill>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeSkillCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Skill_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSkill)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Skills_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeSkillModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Skill_ModifiedBy_User");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.EmployeeSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employee_Skills_Skills");
            });

            modelBuilder.Entity<EmployeeUnionTrustee>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeUnionTrusteeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeUnionTrustee_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeUnionTrustee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeUnionTrustee_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeUnionTrusteeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeUnionTrustee_ModifiedBy_User");

                entity.HasOne(d => d.Union)
                    .WithMany(p => p.EmployeeUnionTrustee)
                    .HasForeignKey(d => d.UnionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmployeeUnionTrustee_Union");
            });

            modelBuilder.Entity<Employment>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("idx_EmployeeId");

                entity.HasIndex(e => e.ProfitCenterId)
                    .HasName("idx_profitcenterid");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.HoursGuaranteed).HasColumnType("numeric");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.OvertimeAllowedHours)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmploymentCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employment_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employment)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employment_Employee");

                entity.HasOne(d => d.EmploymentCategory)
                    .WithMany(p => p.Employment)
                    .HasForeignKey(d => d.EmploymentCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employment_EmploymentCategory");

                entity.HasOne(d => d.EmploymentFormType)
                    .WithMany(p => p.Employment)
                    .HasForeignKey(d => d.EmploymentFormTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employment_EmploymentFormType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmploymentModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employment_ModifiedBy_User");

                entity.HasOne(d => d.PersonalContract)
                    .WithMany(p => p.EmploymentPersonalContract)
                    .HasForeignKey(d => d.PersonalContractId)
                    .HasConstraintName("FK_Employment_WorkContract");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.Employment)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Employment_ProfitCenter");

                entity.HasOne(d => d.UnionContract)
                    .WithMany(p => p.EmploymentUnionContract)
                    .HasForeignKey(d => d.UnionContractId)
                    .HasConstraintName("FK_Employment_WorkContract_Union");
            });

            modelBuilder.Entity<EmploymentCategory>(entity =>
            {
                entity.Property(e => e.Categorization).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DefaultHoursGuaranteed).HasColumnType("numeric");

                entity.Property(e => e.EmploymentCategoryNumber)
                    .IsRequired()
                    .HasColumnType("char(3)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.ShowInGsp).HasDefaultValueSql("1");

                entity.Property(e => e.ShowInSep).HasDefaultValueSql("1");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmploymentCategoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmploymentCategory_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmploymentCategoryModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmploymentCategory_ModifiedBy_User");
            });

            modelBuilder.Entity<EmploymentFormType>(entity =>
            {
                entity.Property(e => e.EmploymentFormTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");
            });

            modelBuilder.Entity<EmploymentHoursGuaranteed>(entity =>
            {
                entity.Property(e => e.EmploymentHoursGuaranteedId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.HoursGuaranteed).HasColumnType("numeric");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmploymentHoursGuaranteedCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmploymentHoursGuaranteed_CreatedBy_User");

                entity.HasOne(d => d.Employment)
                    .WithMany(p => p.EmploymentHoursGuaranteed)
                    .HasForeignKey(d => d.EmploymentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmploymentHoursGuaranteed_Employment");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmploymentHoursGuaranteedModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EmploymentHoursGuaranteed_ModifiedBy_User");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.HasIndex(e => e.TypeName)
                    .HasName("IX_Entity_TypeName");

                entity.Property(e => e.EntityId).ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EntityCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Entity_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EntityModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Entity_ModifiedBy_User");
            });

            modelBuilder.Entity<EntityDefinition>(entity =>
            {
                entity.HasKey(e => e.EntityId)
                    .HasName("PK_EntityDefinition");

                entity.Property(e => e.EntityId).ValueGeneratedNever();

                entity.HasOne(d => d.Entity)
                    .WithOne(p => p.EntityDefinition)
                    .HasForeignKey<EntityDefinition>(d => d.EntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EntityDefinition_Entity");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.PlanningUnitNumber).HasColumnType("varchar(4)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EventLogCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EventLog_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EventLogModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EventLog_ModifiedBy_User");
            });

            modelBuilder.Entity<FakeUserData>(entity =>
            {
                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.FakeUserData)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FakeUserData_Language");
            });

            modelBuilder.Entity<FictiveSchedulingData>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FictiveSchedulingDataCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingData_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FictiveSchedulingDataModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingData_ModifiedBy_User");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.FictiveSchedulingData)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingData_ProfitCenter");
            });

            modelBuilder.Entity<FictiveSchedulingShift>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FictiveSchedulingShiftCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShift_CreatedBy_User");

                entity.HasOne(d => d.DayType)
                    .WithMany(p => p.FictiveSchedulingShift)
                    .HasForeignKey(d => d.DayTypeId)
                    .HasConstraintName("FK_FictiveSchedulingShift_DayType");

                entity.HasOne(d => d.FictiveSchedulingData)
                    .WithMany(p => p.FictiveSchedulingShift)
                    .HasForeignKey(d => d.FictiveSchedulingDataId)
                    .HasConstraintName("FK_FictiveSchedulingShift_FictiveSchedulingData");

                entity.HasOne(d => d.FictiveSchedulingShiftType)
                    .WithMany(p => p.FictiveSchedulingShift)
                    .HasForeignKey(d => d.FictiveSchedulingShiftTypeId)
                    .HasConstraintName("FK_FictiveSchedulingShift_FictiveSchedulingShiftType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FictiveSchedulingShiftModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShift_ModifiedBy_User");
            });

            modelBuilder.Entity<FictiveSchedulingShiftType>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FictiveSchedulingShiftTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShiftType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FictiveSchedulingShiftTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShiftType_ModifiedBy_User");
            });

            modelBuilder.Entity<FictiveSchedulingShiftTypeHour>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FictiveSchedulingShiftTypeHourCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShiftTypeHour_CreatedBy_User");

                entity.HasOne(d => d.FictiveSchedulingShiftType)
                    .WithMany(p => p.FictiveSchedulingShiftTypeHour)
                    .HasForeignKey(d => d.FictiveSchedulingShiftTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShiftTypeHour_FictiveSchedulingShiftType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FictiveSchedulingShiftTypeHourModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShiftTypeHour_ModifiedBy_User");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.FictiveSchedulingShiftTypeHour)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FictiveSchedulingShiftTypeHour_ProfitCenter");
            });

            modelBuilder.Entity<InconvenientHourCalendar>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InconvenientHourCalendarCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InconvenientHourCalendar_CreatedBy_User");

                entity.HasOne(d => d.InconvenientHourRank)
                    .WithMany(p => p.InconvenientHourCalendar)
                    .HasForeignKey(d => d.InconvenientHourRankId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InconvenientHourCalendar_InconvenientHourRank");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InconvenientHourCalendarModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InconvenientHourCalendar_ModifiedBy_User");

                entity.HasOne(d => d.WorkContract)
                    .WithMany(p => p.InconvenientHourCalendar)
                    .HasForeignKey(d => d.WorkContractId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InconvenientHourCalendar_WorkContract");
            });

            modelBuilder.Entity<InconvenientHourRank>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InconvenientHourRankCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InconvenientHourRank_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InconvenientHourRankModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InconvenientHourRank_ModifiedBy_User");

                entity.HasOne(d => d.WorkContract)
                    .WithMany(p => p.InconvenientHourRank)
                    .HasForeignKey(d => d.WorkContractId)
                    .HasConstraintName("FK_InconvenientHourRank_WorkContract");
            });

            modelBuilder.Entity<IntegrationEmployees>(entity =>
            {
                entity.ToTable("IntegrationEmployees", "NonGSPCore");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasDefaultValueSql("getdate()");

                entity.Property(e => e.IsNew).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<IntegrationPlanningUnits>(entity =>
            {
                entity.ToTable("IntegrationPlanningUnits", "NonGSPCore");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasDefaultValueSql("getdate()");

                entity.Property(e => e.IsNew).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<IntegrationProfitCenters>(entity =>
            {
                entity.ToTable("IntegrationProfitCenters", "NonGSPCore");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasDefaultValueSql("getdate()");

                entity.Property(e => e.IsNew).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<InvoiceAddress>(entity =>
            {
                entity.Property(e => e.InvoiceAddressId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.InvoiceAddressNumber).HasColumnType("varchar(9)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(35)");

                entity.Property(e => e.Zipcode)
                    .IsRequired()
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InvoiceAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InvoiceAddress_Customer");
            });

            modelBuilder.Entity<JobConfig>(entity =>
            {
                entity.Property(e => e.ServerName).HasColumnType("varchar(50)");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.JobConfig)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobConfig_JobType");
            });

            modelBuilder.Entity<JobDefinition>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Parameters).HasColumnType("xml");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobDefinitionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobDefinition_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.JobDefinitionModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobDefinition_ModifiedBy_User");
            });

            modelBuilder.Entity<JobLogItem>(entity =>
            {
                entity.HasIndex(e => e.JobRunId)
                    .HasName("IX_JobLogItem_JobRunId");

                entity.HasIndex(e => new { e.BookingChangeTraceId, e.Handled, e.EmployeeId, e.StartDate, e.EndDate })
                    .HasName("IX_JobLogItem_EmployeeId");

                entity.HasIndex(e => new { e.JobLogItemId, e.BookingChangeTraceId, e.StartDate, e.EndDate, e.Handled, e.PlanningUnitId })
                    .HasName("IX_JobLogItem_PlanningUnitId");

                entity.HasIndex(e => new { e.JobLogItemId, e.BookingChangeTraceId, e.StartDate, e.EndDate, e.Handled, e.ProfitCenterId })
                    .HasName("IX_JobLogItem_ProfitCenterId");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.RuleName).HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobLogItemCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobLogItem_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.JobLogItemModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobLogItem_ModifiedBy_User");
            });

            modelBuilder.Entity<JobRun>(entity =>
            {
                entity.HasIndex(e => new { e.JobDefinitionId, e.Status })
                    .HasName("IX_JobDefinitionId_Status");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Parameters).HasColumnType("xml");

                entity.Property(e => e.Servername).HasColumnType("varchar(100)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobRunCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobRun_CreatedBy_User");

                entity.HasOne(d => d.JobDefinition)
                    .WithMany(p => p.JobRun)
                    .HasForeignKey(d => d.JobDefinitionId)
                    .HasConstraintName("FK_JobRun_JobDefinition");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.JobRunModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobRun_ModifiedBy_User");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.Property(e => e.JobTypeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.JobTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.JobTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_JobType_ModifiedBy_User");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.LangKey)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Exception).HasColumnType("varchar(max)");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Sent).HasDefaultValueSql("0");

                entity.Property(e => e.SystemUser)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasKey(e => e.OrganizationBranchId)
                    .HasName("PK__Organiza__EC4E19F761316BF4");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ExternalId).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrgLevel)
                    .HasComputedColumnSql("[OrgNode].[GetLevel]()")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.OrgPath)
                    .HasComputedColumnSql("[OrgNode].[ToString]()")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<PlanningGroup>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AttendanceAddress).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.EmailAddress).HasMaxLength(255);

                entity.Property(e => e.PlanningGroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlanningGroupNumber)
                    .IsRequired()
                    .HasMaxLength(9);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.StateOrProvince).HasMaxLength(100);

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.PlanningGroupType)
                    .WithMany(p => p.PlanningGroup)
                    .HasForeignKey(d => d.PlanningGroupTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroup_PlanningGroupType");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.PlanningGroup)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroup_ProfitCenter");
            });

            modelBuilder.Entity<PlanningGroupGenderConstraint>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningGroupGenderConstraintCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroupGenderConstraint_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningGroupGenderConstraintModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroupGenderConstraint_ModifiedBy_User");

                entity.HasOne(d => d.PlanningGroup)
                    .WithMany(p => p.PlanningGroupGenderConstraint)
                    .HasForeignKey(d => d.PlanningGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroupGenderConstraint_PlanningGroup");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.PlanningGroupGenderConstraint)
                    .HasForeignKey(d => d.QualificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroupGenderConstraint_Qualification");
            });

            modelBuilder.Entity<PlanningGroupPlanningUnit>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningGroupPlanningUnitCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroup_PlanningUnit_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningGroupPlanningUnitModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroup_PlanningUnit_ModifiedBy_User");

                entity.HasOne(d => d.PlanningGroup)
                    .WithMany(p => p.PlanningGroupPlanningUnit)
                    .HasForeignKey(d => d.PlanningGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroup_PlanningUnit_PlanningGroup");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningGroupPlanningUnit)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningGroup_PlanningUnit_PlanningUnit");
            });

            modelBuilder.Entity<PlanningGroupType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<PlanningPeriod>(entity =>
            {
                entity.HasIndex(e => new { e.DateFrom, e.DateTo, e.PeriodLength, e.TimePeriodType, e.EmployeeId })
                    .HasName("IX_PlanningPeriodId");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningPeriodCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningPeriod_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PlanningPeriod)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningPeriod_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningPeriodModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningPeriod_ModifiedBy_User");
            });

            modelBuilder.Entity<PlanningPeriodDateDefinition>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlanningUnit>(entity =>
            {
                entity.HasIndex(e => new { e.PlanningUnitNumber, e.ProfitCenterId })
                    .HasName("IX_PlanningUnit")
                    .IsUnique();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AttendanceAddress).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ExportToGmp)
                    .HasColumnName("ExportToGMP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.PlanningUnitNumber)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitType)
                    .WithMany(p => p.PlanningUnit)
                    .HasForeignKey(d => d.PlanningUnitTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_PlanningUnitType");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.PlanningUnit)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_ProfitCenter");
            });

            modelBuilder.Entity<PlanningUnitApproval>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.Approval)
                    .WithMany(p => p.PlanningUnitApproval)
                    .HasForeignKey(d => d.ApprovalId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Approval_Qualifications");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitApprovalCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Approval_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitApprovalModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Approval_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitApproval)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Approval_PlanningUnit");
            });

            modelBuilder.Entity<PlanningUnitCost>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitCostCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitCost_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitCostModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitCost_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitCostType)
                    .WithMany(p => p.PlanningUnitCost)
                    .HasForeignKey(d => d.PlanningUnitCostTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitCost_PlanningUnitCostType");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitCost)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitCost_PlanningUnit");
            });

            modelBuilder.Entity<PlanningUnitCostType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");
            });

            modelBuilder.Entity<PlanningUnitDefinition>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.PlanningUnitNumber)
                    .IsRequired()
                    .HasColumnType("varchar(4)");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.HasOne(d => d.PlanningUnitType)
                    .WithMany(p => p.PlanningUnitDefinition)
                    .HasForeignKey(d => d.PlanningUnitTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitDefinition_PlanningUnitType");
            });

            modelBuilder.Entity<PlanningUnitNote>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ShowNoteInSep)
                    .HasColumnName("ShowNoteInSEP")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitNoteCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitNote_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitNoteModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitNote_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitNote)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitNote_PlanningUnit");
            });

            modelBuilder.Entity<PlanningUnitQualification>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitQualificationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Qualification_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitQualificationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Qualification_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitQualification)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Qualifications_PlanningUnit");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.PlanningUnitQualification)
                    .HasForeignKey(d => d.QualificationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Qualifications_Qualifications");
            });

            modelBuilder.Entity<PlanningUnitSalarySupplement>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitSalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitSalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSalarySupplement_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitSalarySupplement)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSalarySupplement_PlanningUnitVersion");

                entity.HasOne(d => d.SalarySupplement)
                    .WithMany(p => p.PlanningUnitSalarySupplement)
                    .HasForeignKey(d => d.SalarySupplementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSalarySupplement_SalarySupplement");
            });

            modelBuilder.Entity<PlanningUnitShift>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DurationInMinutes).HasDefaultValueSql("0");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitShiftCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShift_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitShiftModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShift_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitVersion)
                    .WithMany(p => p.PlanningUnitShift)
                    .HasForeignKey(d => d.PlanningUnitVersionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShift_PlanningUnitVersion");

                entity.HasOne(d => d.VacancyCode)
                    .WithMany(p => p.PlanningUnitShift)
                    .HasForeignKey(d => d.VacancyCodeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShift_VacancyCode");
            });

            modelBuilder.Entity<PlanningUnitShiftBreak>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitShiftBreakCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShiftBreak_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitShiftBreakModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShiftBreak_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitShift)
                    .WithMany(p => p.PlanningUnitShiftBreak)
                    .HasForeignKey(d => d.PlanningUnitShiftId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitShiftBreak_PlanningUnitShift");
            });

            modelBuilder.Entity<PlanningUnitSkill>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitSkill)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Skill_CreatedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitSkill)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Skills_PlanningUnit");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.PlanningUnitSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnit_Skills_Skills");
            });

            modelBuilder.Entity<PlanningUnitSpecification>(entity =>
            {
                entity.HasIndex(e => e.PlanningUnitId)
                    .HasName("IX_PlanningUnitSpecification_PlanningUnitId");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitSpecificationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecification_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitSpecificationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecification_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitSpecification)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecification_PlanningUnit");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PlanningUnitSpecification)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecification_Product");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.PlanningUnitSpecification)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .HasConstraintName("FK_PlanningUnitSpecification_ProfitCenter");
            });

            modelBuilder.Entity<PlanningUnitSpecificationDayType>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitSpecificationDayTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayType_CreatedBy_User");

                entity.HasOne(d => d.DayType)
                    .WithMany(p => p.PlanningUnitSpecificationDayType)
                    .HasForeignKey(d => d.DayTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayType_DayType");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitSpecificationDayTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayType_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitVersion)
                    .WithMany(p => p.PlanningUnitSpecificationDayType)
                    .HasForeignKey(d => d.PlanningUnitVersionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayType_PlanningUnitVersion");
            });

            modelBuilder.Entity<PlanningUnitSpecificationDayTypeValue>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitSpecificationDayTypeValueCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayTypeValue_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitSpecificationDayTypeValueModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayTypeValue_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitSpecificationDayType)
                    .WithMany(p => p.PlanningUnitSpecificationDayTypeValue)
                    .HasForeignKey(d => d.PlanningUnitSpecificationDayTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayTypeValue_PlanningUnitSpecificationDayType");

                entity.HasOne(d => d.PlanningUnitSpecificationDayTypeValueType)
                    .WithMany(p => p.PlanningUnitSpecificationDayTypeValue)
                    .HasForeignKey(d => d.PlanningUnitSpecificationDayTypeValueTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitSpecificationDayTypeValue_PlanningUnitSpecificationDayTypeValueType");
            });

            modelBuilder.Entity<PlanningUnitSpecificationDayTypeValueType>(entity =>
            {
                entity.Property(e => e.PlanningUnitSpecificationDayTypeValueTypeId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PlanningUnitType>(entity =>
            {
                entity.Property(e => e.AllowLearningTime).HasDefaultValueSql("0");

                entity.Property(e => e.AllowOverlappingShifts).HasDefaultValueSql("0");

                entity.Property(e => e.AllowedOnPlannedSchedule).HasDefaultValueSql("0");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DeductsFromOtherTime).HasDefaultValueSql("0");

                entity.Property(e => e.DoubleBookingOnPlanningUnitAllowed).HasDefaultValueSql("0");

                entity.Property(e => e.IsWorkTime).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TimeReporting).HasDefaultValueSql("0");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitType_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitType_ModifiedBy_User");
            });

            modelBuilder.Entity<PlanningUnitTypeSalarySupplement>(entity =>
            {
                entity.ToTable("PlanningUnitType_SalarySupplement");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ImportedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitTypeSalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitType_SalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitTypeSalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitType_SalarySupplement_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnitType)
                    .WithMany(p => p.PlanningUnitTypeSalarySupplement)
                    .HasForeignKey(d => d.PlanningUnitTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitType_SalarySupplement_PlanningUnitType");

                entity.HasOne(d => d.SalarySupplement)
                    .WithMany(p => p.PlanningUnitTypeSalarySupplement)
                    .HasForeignKey(d => d.SalarySupplementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitType_SalarySupplement_SalarySupplement");
            });

            modelBuilder.Entity<PlanningUnitVersion>(entity =>
            {
                entity.HasIndex(e => new { e.PlanningUnitVersionId, e.ValidFrom, e.ValidTo, e.PlanningUnitId })
                    .HasName("IX_PlanningUnitVersionIdFromTo");

                entity.Property(e => e.AllowBookingsOutsideShiftFrom).HasColumnType("time(0)");

                entity.Property(e => e.AllowBookingsOutsideShiftTo).HasColumnType("time(0)");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.IsHardWeek).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlanningUnitVersionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitVersion_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlanningUnitVersionModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitVersion_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.PlanningUnitVersion)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PlanningUnitVersions_PlanningUnits");

                entity.HasOne(d => d.SalaryGroup)
                    .WithMany(p => p.PlanningUnitVersion)
                    .HasForeignKey(d => d.SalaryGroupId)
                    .HasConstraintName("FK_PlanningUnitVersion_SalaryGroup");
            });

            modelBuilder.Entity<PreFilter>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Filter).HasColumnType("xml");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PreFilter)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PreFilter_CreatedBy_User");
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Unc)
                    .IsRequired()
                    .HasMaxLength(750);
            });

            modelBuilder.Entity<PrinterProfitCenter>(entity =>
            {
                entity.HasKey(e => new { e.PrinterId, e.ProfitCenterId })
                    .HasName("PK_Printer_ProfitCenter");

                entity.ToTable("Printer_ProfitCenter");

                entity.HasOne(d => d.Printer)
                    .WithMany(p => p.PrinterProfitCenter)
                    .HasForeignKey(d => d.PrinterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Printer_ProfitCenter_Printer");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.PrinterProfitCenter)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Printer_ProfitCenter_ProfitCenter");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ImportedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Miscellaneous).HasMaxLength(2000);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Product_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Product_ModifiedBy_User");
            });

            modelBuilder.Entity<ProductSalarySupplement>(entity =>
            {
                entity.ToTable("Product_SalarySupplement");

                entity.Property(e => e.ProductSalarySupplementId).HasColumnName("Product_SalarySupplementId");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ImportedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductSalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Product_SalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductSalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Product_SalarySupplement_ModifiedBy_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSalarySupplement)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Product_SalarySupplement_ProductId");

                entity.HasOne(d => d.SalarySupplement)
                    .WithMany(p => p.ProductSalarySupplement)
                    .HasForeignKey(d => d.SalarySupplementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Product_SalarySupplement_SalarySupplementId");
            });

            modelBuilder.Entity<ProfitCenter>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.IsAdministrative).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.Property(e => e.ProfitCenterNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PublishToEmployeePortal).HasDefaultValueSql("1");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProfitCenterCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenter_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProfitCenterModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenter_ModifiedBy_User");
            });

            modelBuilder.Entity<ProfitCenterLocking>(entity =>
            {
                entity.HasKey(e => e.ProfitCenterId)
                    .HasName("PK__ProfitCe__55D36F094C974E93");

                entity.HasIndex(e => e.AppServerName)
                    .HasName("IX_ProfitCenterLocking_AppServerName");

                entity.Property(e => e.ProfitCenterId).ValueGeneratedNever();

                entity.Property(e => e.AppServerName).HasColumnType("varchar(25)");

                entity.Property(e => e.LockCreated)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<ProfitCenterRight>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProfitCenterRightCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenterRight_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProfitCenterRightModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenterRight_ModifiedBy_User");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.ProfitCenterRight)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenterRight_ProfitCenter");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.ProfitCenterRight)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenterRight_SecurityRole");

                entity.HasOne(d => d.SystemUser)
                    .WithMany(p => p.ProfitCenterRightSystemUser)
                    .HasForeignKey(d => d.SystemUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfitCenterRight_SystemUser");
            });

            modelBuilder.Entity<Qualification>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.QualificationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Qualification_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.QualificationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Qualification_ModifiedBy_User");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Icon).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OneProfitCenterOnly).HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Report_ReportGroup");
            });

            modelBuilder.Entity<ReportFilter>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.FilterId })
                    .HasName("PK_Report_Filter");

                entity.ToTable("Report_Filter");

                entity.HasOne(d => d.Filter)
                    .WithMany(p => p.ReportFilter)
                    .HasForeignKey(d => d.FilterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Report_Filter_Filter");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportFilter)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Report_Filter_Report");
            });

            modelBuilder.Entity<ReportFilter1>(entity =>
            {
                entity.HasKey(e => e.FilterId)
                    .HasName("PK_ReportFilter");

                entity.ToTable("ReportFilter");

                entity.Property(e => e.FilterId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_ReportGroup");

                entity.Property(e => e.GroupId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportLabelLanguage>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ReportLabelLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportLabelLanguage_Language");
            });

            modelBuilder.Entity<ReportView>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.ViewId })
                    .HasName("PK_Report_View");

                entity.ToTable("Report_View");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportView)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Report_View_Report");
            });

            modelBuilder.Entity<SalaryGroup>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SalaryGroupNumber).HasColumnType("varchar(4)");

                entity.Property(e => e.ShowInGsp).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<SalaryRun>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.SalaryMonth).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SalaryRun)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SalaryRun_CreatedBy_User");
            });

            modelBuilder.Entity<SalarySupplement>(entity =>
            {
                entity.Property(e => e.CanConnectToEmployee).HasDefaultValueSql("0");

                entity.Property(e => e.CanConnectToPlanningUnit).HasDefaultValueSql("0");

                entity.Property(e => e.CanConnectToPlanningUnitSpecification).HasDefaultValueSql("0");

                entity.Property(e => e.CanConnectToTimeAccounting).HasDefaultValueSql("0");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ImportedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalarySupplementNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SalarySupplementCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SalarySupplement_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SalarySupplementModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SalarySupplement_ModifiedBy_User");
            });

            modelBuilder.Entity<SchedulingData>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SchedulingDataNumber)
                    .IsRequired()
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingData_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingData_ModifiedBy_User");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.SchedulingData)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingData_ProfitCenter");
            });

            modelBuilder.Entity<SchedulingDataCycle>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataCycleCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataCycle_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataCycleModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataCycle_ModifiedBy_User");
            });

            modelBuilder.Entity<SchedulingDataCycleRow>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Friday).HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Monday).HasDefaultValueSql("0");

                entity.Property(e => e.Saturday).HasDefaultValueSql("0");

                entity.Property(e => e.Sunday).HasDefaultValueSql("0");

                entity.Property(e => e.Thursday).HasDefaultValueSql("0");

                entity.Property(e => e.Tuesday).HasDefaultValueSql("0");

                entity.Property(e => e.Wednesday).HasDefaultValueSql("0");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataCycleRowCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataCycleRow_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataCycleRowModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataCycleRow_ModifiedBy_User");

                entity.HasOne(d => d.SchedulingDataCycle)
                    .WithMany(p => p.SchedulingDataCycleRow)
                    .HasForeignKey(d => d.SchedulingDataCycleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataCycleRow_SchedulingDataCycle");
            });

            modelBuilder.Entity<SchedulingDataRolloutHistory>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.EmployeeDateFrom).HasColumnType("date");

                entity.Property(e => e.EmployeeDateTo).HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataRolloutHistoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataRolloutHistory_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SchedulingDataRolloutHistory)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataRolloutHistory_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataRolloutHistoryModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataRolloutHistory_ModifiedBy_User");

                entity.HasOne(d => d.SchedulingData)
                    .WithMany(p => p.SchedulingDataRolloutHistory)
                    .HasForeignKey(d => d.SchedulingDataId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataRolloutHistory_SchedulingData");
            });

            modelBuilder.Entity<SchedulingDataScheduleRow>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataScheduleRowCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataSchedule_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataScheduleRowModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataSchedule_ModifiedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.SchedulingDataScheduleRow)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataSchedule_PlanningUnit");

                entity.HasOne(d => d.SchedulingDataShift)
                    .WithMany(p => p.SchedulingDataScheduleRow)
                    .HasForeignKey(d => d.SchedulingDataShiftId)
                    .HasConstraintName("FK_SchedulingDataSchedule_SchedulingDataShift");

                entity.HasOne(d => d.SchedulingDataVersion)
                    .WithMany(p => p.SchedulingDataScheduleRow)
                    .HasForeignKey(d => d.SchedulingDataVersionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataScheduleRow_SchedulingDataVersion");
            });

            modelBuilder.Entity<SchedulingDataShift>(entity =>
            {
                entity.Property(e => e.BreakXml).HasColumnType("xml");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataShiftCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataShift_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataShiftModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataShift_ModifiedBy_User");
            });

            modelBuilder.Entity<SchedulingDataVersion>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.RollOutStartDate).HasColumnType("date");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataVersionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersion_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataVersionModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersion_ModifiedBy_User");

                entity.HasOne(d => d.SchedulingData)
                    .WithMany(p => p.SchedulingDataVersion)
                    .HasForeignKey(d => d.SchedulingDataId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersion_SchedulingData");
            });

            modelBuilder.Entity<SchedulingDataVersionEmployee>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulingDataVersionEmployeeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersionEmployee_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SchedulingDataVersionEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersionEmployee_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulingDataVersionEmployeeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersionEmployee_ModifiedBy_User");

                entity.HasOne(d => d.SchedulingDataVersion)
                    .WithMany(p => p.SchedulingDataVersionEmployee)
                    .HasForeignKey(d => d.SchedulingDataVersionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SchedulingDataVersionEmployee_SchedulingDataVersion");
            });

            modelBuilder.Entity<SecurityRole>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("Name");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SecurityRoleCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRole_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SecurityRoleModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRole_ModifiedBy_User");
            });

            modelBuilder.Entity<SecurityRoleAppPartData>(entity =>
            {
                entity.HasIndex(e => new { e.SecurityRoleId, e.ApplicationPartId })
                    .HasName("IX_SecurityRoleAppPartData_SecurityRoleAndAppPartId")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.ApplicationPart)
                    .WithMany(p => p.SecurityRoleAppPartData)
                    .HasForeignKey(d => d.ApplicationPartId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleAppPartData_ApplicationPart");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SecurityRoleAppPartDataCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleAppPartData_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SecurityRoleAppPartDataModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleAppPartData_ModifiedBy_User");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.SecurityRoleAppPartData)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleAppPartData_SecurityRole");
            });

            modelBuilder.Entity<SecurityRoleEntityData>(entity =>
            {
                entity.HasIndex(e => new { e.SecurityRoleId, e.EntityId })
                    .HasName("IX_SecurityRoleEntityData_SecurityRoleAndEntityId")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SecurityRoleEntityDataCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleEntityData_CreatedBy_User");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.SecurityRoleEntityData)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleEntityData_Entity");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SecurityRoleEntityDataModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleEntityData_ModifiedBy_User");

                entity.HasOne(d => d.SecurityRole)
                    .WithMany(p => p.SecurityRoleEntityData)
                    .HasForeignKey(d => d.SecurityRoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SecurityRoleEntityData_SecurityRole");
            });

            modelBuilder.Entity<ShiftCache>(entity =>
            {
                entity.HasIndex(e => new { e.IsScheduled, e.EmployeeId, e.ValidTo, e.StartDate, e.EndDate })
                    .HasName("IX_ShiftCache");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsScheduled).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedOn).HasDefaultValueSql("getdate()");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.ValidTo).HasDefaultValueSql("'2099-01-01'");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ShiftCache)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BookingShift_EmployeeId");
            });

            modelBuilder.Entity<Shifts>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK__Shifts__C0A83881A47A8E4B");

                entity.ToTable("Shifts", "NonGSPCore");

                entity.Property(e => e.IsScheduled).HasDefaultValueSql("1");

                entity.Property(e => e.ValidTo).HasDefaultValueSql("'2099-01-01'");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Shifts)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Shifts_EmployeeId");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SkillCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Skill_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SkillModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Skill_ModifiedBy_User");
            });

            modelBuilder.Entity<SmsList>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SmsListCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SmsList_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SmsListModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SmsList_ModifiedBy_User");
            });

            modelBuilder.Entity<SmsListRow>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SmsListRowCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SmsListRow_CreatedBy_User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SmsListRow)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SmsListRow_Employee");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SmsListRowModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SmsListRow_ModifiedBy_User");

                entity.HasOne(d => d.SmsList)
                    .WithMany(p => p.SmsListRow)
                    .HasForeignKey(d => d.SmsListId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SmsListRow_SmsList");
            });

            modelBuilder.Entity<SmsLog>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ErrorLog).HasMaxLength(500);

                entity.Property(e => e.SmsLogXml)
                    .IsRequired()
                    .HasColumnName("SmsLogXML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SmsLog)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Sms_CreatedBy_User");
            });

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_User_UniqueEmployeeId")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.DashboardSettingsXml)
                    .HasColumnName("DashboardSettingsXML")
                    .HasColumnType("xml");

                entity.Property(e => e.EmployeeId).IsRequired();

                entity.Property(e => e.GridViewsSettingsXml)
                    .HasColumnName("GridViewsSettingsXML")
                    .HasColumnType("xml");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.PartTimeAbsenceIsPlanned).HasDefaultValueSql("1");

                entity.Property(e => e.SearchPeriodIsMonth).HasDefaultValueSql("0");

                entity.Property(e => e.ValidFrom).HasColumnType("date");

                entity.Property(e => e.ValidTo).HasColumnType("date");

                entity.Property(e => e.WeekScheduleLoadSize).HasDefaultValueSql("3");
            });

            modelBuilder.Entity<SystemUserFunction>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Union>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Union)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Union_CreatedBy_User");
            });

            modelBuilder.Entity<VacancyCode>(entity =>
            {
                entity.Property(e => e.VacancyCodeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VacancyCodeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VacancyCode_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.VacancyCodeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VacancyCode_ModifiedBy_User");
            });

            modelBuilder.Entity<VacancyPlanningSimulation>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Operations).HasColumnType("xml");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.VacancyPlanningSimulationCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VacancyPlanningSimulation_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.VacancyPlanningSimulationModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VacancyPlanningSimulation_ModifiedBy_User");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.VacancyPlanningSimulation)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_VacancyPlanningSimulation_ProfitCenterId_ProfitCenter");
            });

            modelBuilder.Entity<ValidBookings>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__ValidBoo__73951AED83291766");

                entity.ToTable("ValidBookings", "NonGSPCore");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.ScheduleType).HasDefaultValueSql("0");

                entity.Property(e => e.ValidTo).HasDefaultValueSql("'2099-01-01'");

                entity.HasOne(d => d.Booking)
                    .WithOne(p => p.ValidBookings)
                    .HasForeignKey<ValidBookings>(d => d.BookingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ValidBookings_BookingID");
            });

            modelBuilder.Entity<WeekScheduleFilter>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ModifiedBy).HasColumnType("ModifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("ModifiedOn");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WeekScheduleFilterCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WeekScheduleFilter_CreatedBy_User");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WeekScheduleFilterModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WeekScheduleFilter_ModifiedBy_User");

                entity.HasOne(d => d.SystemUser)
                    .WithMany(p => p.WeekScheduleFilterSystemUser)
                    .HasForeignKey(d => d.SystemUserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WeekScheduleFilter_ProfitCenter");
            });

            modelBuilder.Entity<WorkContract>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExtendObtime1)
                    .HasColumnName("ExtendOBTime1")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExternalId).HasMaxLength(100);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime2(0)");

                entity.Property(e => e.ValidTo).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WorkContract)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkContract_CreatedBy_User");

                entity.HasOne(d => d.PlanningUnit)
                    .WithMany(p => p.WorkContract)
                    .HasForeignKey(d => d.PlanningUnitId)
                    .HasConstraintName("FK_WorkContract_PlanningUnit");

                entity.HasOne(d => d.ProfitCenter)
                    .WithMany(p => p.WorkContract)
                    .HasForeignKey(d => d.ProfitCenterId)
                    .HasConstraintName("FK_WorkContract_ProfitCenter");

                entity.HasOne(d => d.Union)
                    .WithMany(p => p.WorkContract)
                    .HasForeignKey(d => d.UnionId)
                    .HasConstraintName("FK_WorkContract_Union");
            });

            modelBuilder.Entity<WorkContractParameter>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WorkContractRule>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime2(0)");

                entity.Property(e => e.ValidTo).HasColumnType("datetime2(0)");

                entity.Property(e => e.Value).HasColumnType("decimal");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WorkContractRule)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkContractRule_CreatedBy_User");

                entity.HasOne(d => d.WorkContract)
                    .WithMany(p => p.WorkContractRule)
                    .HasForeignKey(d => d.WorkContractId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkContractRule_WorkContract");

                entity.HasOne(d => d.WorkContractParameter)
                    .WithMany(p => p.WorkContractRule)
                    .HasForeignKey(d => d.WorkContractParameterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkContractRule_WorkContractParameter");
            });

            modelBuilder.Entity<WorkScheduleChangeSet>(entity =>
            {
                entity.HasIndex(e => new { e.WorkScheduleChangeSetId, e.PeriodStartDate, e.ChangeSetTypeId, e.CreatedBy, e.CreatedOn, e.PlanningPeriodId })
                    .HasName("IX_WorkScheduleChangeSet_PlanningPeriodId");

                entity.Property(e => e.CreatedBy).HasColumnType("CreatedBy");

                entity.Property(e => e.CreatedOn).HasColumnType("CreatedOn");

                entity.Property(e => e.PeriodStartDate).HasColumnType("date");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WorkScheduleChangeSet)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkScheduleChangeSet_SystemUser");

                entity.HasOne(d => d.PlanningPeriod)
                    .WithMany(p => p.WorkScheduleChangeSet)
                    .HasForeignKey(d => d.PlanningPeriodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WorkScheduleChangeSet_PlanningPeriod");
            });

            modelBuilder.HasSequence("ChangeTraceId").StartsAt(100000);
        }

        public virtual DbSet<AbsenceType> AbsenceType { get; set; }
        public virtual DbSet<AirportCheckpointConfiguration> AirportCheckpointConfiguration { get; set; }
        public virtual DbSet<AirportCheckpointPassengerConfiguration> AirportCheckpointPassengerConfiguration { get; set; }
        public virtual DbSet<AirportCheckpointStaffConfiguration> AirportCheckpointStaffConfiguration { get; set; }
        public virtual DbSet<AirportCheckpointType> AirportCheckpointType { get; set; }
        public virtual DbSet<AirportConfiguration> AirportConfiguration { get; set; }
        public virtual DbSet<AirportConfigurationEmployee> AirportConfigurationEmployee { get; set; }
        public virtual DbSet<AirportPlanningUnitParameterConfiguration> AirportPlanningUnitParameterConfiguration { get; set; }
        public virtual DbSet<AirportPrognosisImportData> AirportPrognosisImportData { get; set; }
        public virtual DbSet<AirportPrognosisImportDataset> AirportPrognosisImportDataset { get; set; }
        public virtual DbSet<AirportRequirementFileType> AirportRequirementFileType { get; set; }
        public virtual DbSet<AirportRequirementType> AirportRequirementType { get; set; }
        public virtual DbSet<AirportStaffingContractHead> AirportStaffingContractHead { get; set; }
        public virtual DbSet<AirportStaffingContractRule> AirportStaffingContractRule { get; set; }
        public virtual DbSet<AirportStaffingPlanningUnitParameter> AirportStaffingPlanningUnitParameter { get; set; }
        public virtual DbSet<AirportStaffingPrognosis> AirportStaffingPrognosis { get; set; }
        public virtual DbSet<AirportStaffingPrognosisBooking> AirportStaffingPrognosisBooking { get; set; }
        public virtual DbSet<AirportStaffingPrognosisEmployee> AirportStaffingPrognosisEmployee { get; set; }
        public virtual DbSet<AirportStaffingPrognosisParameter> AirportStaffingPrognosisParameter { get; set; }
        public virtual DbSet<AirportStaffingStaff> AirportStaffingStaff { get; set; }
        public virtual DbSet<AirportTerminalConfiguration> AirportTerminalConfiguration { get; set; }
        public virtual DbSet<AllowedEmploymentCategoryAbsenceType> AllowedEmploymentCategoryAbsenceType { get; set; }
        public virtual DbSet<ApplicationPart> ApplicationPart { get; set; }
        public virtual DbSet<ApplicationPartEntity> ApplicationPartEntity { get; set; }
        public virtual DbSet<Approval> Approval { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingCache> BookingCache { get; set; }
        public virtual DbSet<BookingDeletionReason> BookingDeletionReason { get; set; }
        public virtual DbSet<BookingSalarySupplement> BookingSalarySupplement { get; set; }
        public virtual DbSet<BookingType> BookingType { get; set; }
        public virtual DbSet<BookingsInShift> BookingsInShift { get; set; }
        public virtual DbSet<BookingsInShiftCache> BookingsInShiftCache { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractPart> ContractPart { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerObject> CustomerObject { get; set; }
        public virtual DbSet<DayType> DayType { get; set; }
        public virtual DbSet<DayTypeRule> DayTypeRule { get; set; }
        public virtual DbSet<DayTypeRuleValue> DayTypeRuleValue { get; set; }
        public virtual DbSet<DaytypePlanningUnitShift> DaytypePlanningUnitShift { get; set; }
        public virtual DbSet<DaytypeRulePlanningUnitShift> DaytypeRulePlanningUnitShift { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeApproval> EmployeeApproval { get; set; }
        public virtual DbSet<EmployeeDateInterval> EmployeeDateInterval { get; set; }
        public virtual DbSet<EmployeeFictiveSchedulingData> EmployeeFictiveSchedulingData { get; set; }
        public virtual DbSet<EmployeeImage> EmployeeImage { get; set; }
        public virtual DbSet<EmployeeMonthSalarySupplement> EmployeeMonthSalarySupplement { get; set; }
        public virtual DbSet<EmployeeNote> EmployeeNote { get; set; }
        public virtual DbSet<EmployeeOvertimeOverride> EmployeeOvertimeOverride { get; set; }
        public virtual DbSet<EmployeePlanningUnitExperience> EmployeePlanningUnitExperience { get; set; }
        public virtual DbSet<EmployeeQualification> EmployeeQualification { get; set; }
        public virtual DbSet<EmployeeSalarySupplement> EmployeeSalarySupplement { get; set; }
        public virtual DbSet<EmployeeSkill> EmployeeSkill { get; set; }
        public virtual DbSet<EmployeeUnionTrustee> EmployeeUnionTrustee { get; set; }
        public virtual DbSet<Employment> Employment { get; set; }
        public virtual DbSet<EmploymentCategory> EmploymentCategory { get; set; }
        public virtual DbSet<EmploymentFormType> EmploymentFormType { get; set; }
        public virtual DbSet<EmploymentHoursGuaranteed> EmploymentHoursGuaranteed { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityDefinition> EntityDefinition { get; set; }
        public virtual DbSet<EventLog> EventLog { get; set; }
        public virtual DbSet<FakeUserData> FakeUserData { get; set; }
        public virtual DbSet<FictiveSchedulingData> FictiveSchedulingData { get; set; }
        public virtual DbSet<FictiveSchedulingShift> FictiveSchedulingShift { get; set; }
        public virtual DbSet<FictiveSchedulingShiftType> FictiveSchedulingShiftType { get; set; }
        public virtual DbSet<FictiveSchedulingShiftTypeHour> FictiveSchedulingShiftTypeHour { get; set; }
        public virtual DbSet<InconvenientHourCalendar> InconvenientHourCalendar { get; set; }
        public virtual DbSet<InconvenientHourRank> InconvenientHourRank { get; set; }
        public virtual DbSet<IntegrationEmployees> IntegrationEmployees { get; set; }
        public virtual DbSet<IntegrationPlanningUnits> IntegrationPlanningUnits { get; set; }
        public virtual DbSet<IntegrationProfitCenters> IntegrationProfitCenters { get; set; }
        public virtual DbSet<InvoiceAddress> InvoiceAddress { get; set; }
        public virtual DbSet<JobConfig> JobConfig { get; set; }
        public virtual DbSet<JobDefinition> JobDefinition { get; set; }
        public virtual DbSet<JobLogItem> JobLogItem { get; set; }
        public virtual DbSet<JobRun> JobRun { get; set; }
        public virtual DbSet<JobType> JobType { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<PlanningGroup> PlanningGroup { get; set; }
        public virtual DbSet<PlanningGroupGenderConstraint> PlanningGroupGenderConstraint { get; set; }
        public virtual DbSet<PlanningGroupPlanningUnit> PlanningGroupPlanningUnit { get; set; }
        public virtual DbSet<PlanningGroupType> PlanningGroupType { get; set; }
        public virtual DbSet<PlanningPeriod> PlanningPeriod { get; set; }
        public virtual DbSet<PlanningPeriodDateDefinition> PlanningPeriodDateDefinition { get; set; }
        public virtual DbSet<PlanningUnit> PlanningUnit { get; set; }
        public virtual DbSet<PlanningUnitApproval> PlanningUnitApproval { get; set; }
        public virtual DbSet<PlanningUnitCost> PlanningUnitCost { get; set; }
        public virtual DbSet<PlanningUnitCostType> PlanningUnitCostType { get; set; }
        public virtual DbSet<PlanningUnitDefinition> PlanningUnitDefinition { get; set; }
        public virtual DbSet<PlanningUnitNote> PlanningUnitNote { get; set; }
        public virtual DbSet<PlanningUnitQualification> PlanningUnitQualification { get; set; }
        public virtual DbSet<PlanningUnitSalarySupplement> PlanningUnitSalarySupplement { get; set; }
        public virtual DbSet<PlanningUnitShift> PlanningUnitShift { get; set; }
        public virtual DbSet<PlanningUnitShiftBreak> PlanningUnitShiftBreak { get; set; }
        public virtual DbSet<PlanningUnitSkill> PlanningUnitSkill { get; set; }
        public virtual DbSet<PlanningUnitSpecification> PlanningUnitSpecification { get; set; }
        public virtual DbSet<PlanningUnitSpecificationDayType> PlanningUnitSpecificationDayType { get; set; }
        public virtual DbSet<PlanningUnitSpecificationDayTypeValue> PlanningUnitSpecificationDayTypeValue { get; set; }
        public virtual DbSet<PlanningUnitSpecificationDayTypeValueType> PlanningUnitSpecificationDayTypeValueType { get; set; }
        public virtual DbSet<PlanningUnitType> PlanningUnitType { get; set; }
        public virtual DbSet<PlanningUnitTypeSalarySupplement> PlanningUnitTypeSalarySupplement { get; set; }
        public virtual DbSet<PlanningUnitVersion> PlanningUnitVersion { get; set; }
        public virtual DbSet<PreFilter> PreFilter { get; set; }
        public virtual DbSet<Printer> Printer { get; set; }
        public virtual DbSet<PrinterProfitCenter> PrinterProfitCenter { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductSalarySupplement> ProductSalarySupplement { get; set; }
        public virtual DbSet<ProfitCenter> ProfitCenter { get; set; }
        public virtual DbSet<ProfitCenterLocking> ProfitCenterLocking { get; set; }
        public virtual DbSet<ProfitCenterRight> ProfitCenterRight { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportFilter> ReportFilter { get; set; }
        public virtual DbSet<ReportFilter1> ReportFilter1 { get; set; }
        public virtual DbSet<ReportGroup> ReportGroup { get; set; }
        public virtual DbSet<ReportLabelLanguage> ReportLabelLanguage { get; set; }
        public virtual DbSet<ReportView> ReportView { get; set; }
        public virtual DbSet<SalaryGroup> SalaryGroup { get; set; }
        public virtual DbSet<SalaryRun> SalaryRun { get; set; }
        public virtual DbSet<SalarySupplement> SalarySupplement { get; set; }
        public virtual DbSet<SchedulingData> SchedulingData { get; set; }
        public virtual DbSet<SchedulingDataCycle> SchedulingDataCycle { get; set; }
        public virtual DbSet<SchedulingDataCycleRow> SchedulingDataCycleRow { get; set; }
        public virtual DbSet<SchedulingDataRolloutHistory> SchedulingDataRolloutHistory { get; set; }
        public virtual DbSet<SchedulingDataScheduleRow> SchedulingDataScheduleRow { get; set; }
        public virtual DbSet<SchedulingDataShift> SchedulingDataShift { get; set; }
        public virtual DbSet<SchedulingDataVersion> SchedulingDataVersion { get; set; }
        public virtual DbSet<SchedulingDataVersionEmployee> SchedulingDataVersionEmployee { get; set; }
        public virtual DbSet<SecurityRole> SecurityRole { get; set; }
        public virtual DbSet<SecurityRoleAppPartData> SecurityRoleAppPartData { get; set; }
        public virtual DbSet<SecurityRoleEntityData> SecurityRoleEntityData { get; set; }
        public virtual DbSet<ShiftCache> ShiftCache { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<SmsList> SmsList { get; set; }
        public virtual DbSet<SmsListRow> SmsListRow { get; set; }
        public virtual DbSet<SmsLog> SmsLog { get; set; }
        public virtual DbSet<SystemUser> SystemUser { get; set; }
        public virtual DbSet<SystemUserFunction> SystemUserFunction { get; set; }
        public virtual DbSet<Union> Union { get; set; }
        public virtual DbSet<VacancyCode> VacancyCode { get; set; }
        public virtual DbSet<VacancyPlanningSimulation> VacancyPlanningSimulation { get; set; }
        public virtual DbSet<ValidBookings> ValidBookings { get; set; }
        public virtual DbSet<WeekScheduleFilter> WeekScheduleFilter { get; set; }
        public virtual DbSet<WorkContract> WorkContract { get; set; }
        public virtual DbSet<WorkContractParameter> WorkContractParameter { get; set; }
        public virtual DbSet<WorkContractRule> WorkContractRule { get; set; }
        public virtual DbSet<WorkScheduleChangeSet> WorkScheduleChangeSet { get; set; }

        // Unable to generate entity type for table 'dbo.BookingNote'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PlanningGroupInvoice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PlanningUnitInvoice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BookingChangeTraceIdMax'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LoggedPlanningPeriods'. Please see the warning messages.
    }
}