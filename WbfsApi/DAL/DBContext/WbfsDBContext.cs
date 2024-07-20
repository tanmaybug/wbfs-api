using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WbfsApi.DAL.Entities;

namespace WbfsApi.DAL.DBContext;

public partial class WbfsDBContext : DbContext
{
    public WbfsDBContext()
    {
    }

    public WbfsDBContext(DbContextOptions<WbfsDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WfsApplicationDetail> WfsApplicationDetails { get; set; }

    public virtual DbSet<WfsApplicationDetailsDeactive> WfsApplicationDetailsDeactives { get; set; }

    public virtual DbSet<WfsApplicationTrackHistory> WfsApplicationTrackHistories { get; set; }

    public virtual DbSet<WfsCourseDisciplineMap> WfsCourseDisciplineMaps { get; set; }

    public virtual DbSet<WfsCourseDisciplineMaster> WfsCourseDisciplineMasters { get; set; }

    public virtual DbSet<WfsCourseMaster> WfsCourseMasters { get; set; }

    public virtual DbSet<WfsDistrictMaster> WfsDistrictMasters { get; set; }

    public virtual DbSet<WfsFeeStructureMaster> WfsFeeStructureMasters { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetail> WfsFreeshipCalculationDetails { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetails2018> WfsFreeshipCalculationDetails2018s { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetails2019> WfsFreeshipCalculationDetails2019s { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetails2020> WfsFreeshipCalculationDetails2020s { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetails2021> WfsFreeshipCalculationDetails2021s { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetailsArchive> WfsFreeshipCalculationDetailsArchives { get; set; }

    public virtual DbSet<WfsFreeshipCalculationDetailsArchive2018> WfsFreeshipCalculationDetailsArchive2018s { get; set; }

    public virtual DbSet<WfsGenderMaster> WfsGenderMasters { get; set; }

    public virtual DbSet<WfsInstitutionMaster> WfsInstitutionMasters { get; set; }

    public virtual DbSet<WfsMqMap> WfsMqMaps { get; set; }

    public virtual DbSet<WfsMqMap2018> WfsMqMap2018s { get; set; }

    public virtual DbSet<WfsMqMap2019> WfsMqMap2019s { get; set; }

    public virtual DbSet<WfsMqMap2020> WfsMqMap2020s { get; set; }

    public virtual DbSet<WfsMqMap2021> WfsMqMap2021s { get; set; }

    public virtual DbSet<WfsMqMapBackup> WfsMqMapBackups { get; set; }

    public virtual DbSet<WfsPrivilegeMaster> WfsPrivilegeMasters { get; set; }

    public virtual DbSet<WfsQualifyingExamMaster> WfsQualifyingExamMasters { get; set; }

    public virtual DbSet<WfsStakeLevel> WfsStakeLevels { get; set; }

    public virtual DbSet<WfsStakeLevelType> WfsStakeLevelTypes { get; set; }

    public virtual DbSet<WfsStakeUserLogin> WfsStakeUserLogins { get; set; }

    public virtual DbSet<WfsStatusMaster> WfsStatusMasters { get; set; }

    public virtual DbSet<WfsTwelfthStdBoardMaster> WfsTwelfthStdBoardMasters { get; set; }

    public virtual DbSet<WfsUploadDocument> WfsUploadDocuments { get; set; }

    public virtual DbSet<WfsVerificationDetail> WfsVerificationDetails { get; set; }

    public virtual DbSet<WfsVerificationDetailsBack1112> WfsVerificationDetailsBack1112s { get; set; }

    public virtual DbSet<WfsVerificationDetailsBackup> WfsVerificationDetailsBackups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=wbfs;Username=postgres;Password=admin;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WfsApplicationDetail>(entity =>
        {
            entity.HasKey(e => e.WfsRegistrationNo).HasName("wfs_application_details_pkey");

            entity.Property(e => e.AllowStatus).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<WfsApplicationTrackHistory>(entity =>
        {
            entity.HasKey(e => e.TrackIdPk).HasName("wfs_application_track_history_pkey");
        });

        modelBuilder.Entity<WfsCourseDisciplineMap>(entity =>
        {
            entity.HasKey(e => e.CourseDisciplineMapIdPk).HasName("wfs_course_discipline_map_pkey");

            entity.Property(e => e.ActiveStatus).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<WfsCourseDisciplineMaster>(entity =>
        {
            entity.HasKey(e => e.DisciplineIdPk).HasName("wfs_course_discipline_master_pkey");
        });

        modelBuilder.Entity<WfsCourseMaster>(entity =>
        {
            entity.HasKey(e => e.CourseIdPk).HasName("wfs_course_master_pkey");

            entity.Property(e => e.ActiveStatus).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<WfsDistrictMaster>(entity =>
        {
            entity.HasKey(e => e.DistrictIdPk).HasName("wfs_district_master_pkey");
        });

        modelBuilder.Entity<WfsFeeStructureMaster>(entity =>
        {
            entity.HasKey(e => e.FeeStructureIdPk).HasName("wfs_fee_structure_master_pkey");

            entity.Property(e => e.ActiveStatus).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetail>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcIdPk).HasName("wfs_freeship_calculation_details_pkey2");

            entity.Property(e => e.FreeshipCalcIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details_freeship_calc_id_pk_seq4'::regclass)");
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetails2018>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcIdPk).HasName("wfs_freeship_calculation_details_2018_pkey");

            entity.Property(e => e.FreeshipCalcIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details_freeship_calc_id_pk_seq'::regclass)");
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetails2019>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcIdPk).HasName("wfs_freeship_calculation_details_2019_pkey");

            entity.Property(e => e.FreeshipCalcIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details_freeship_calc_id_pk_seq1'::regclass)");
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetails2020>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcIdPk).HasName("wfs_freeship_calculation_details_pkey");

            entity.Property(e => e.FreeshipCalcIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details_freeship_calc_id_pk_seq2'::regclass)");
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetails2021>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcIdPk).HasName("wfs_freeship_calculation_details_pkey1");

            entity.Property(e => e.FreeshipCalcIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details_freeship_calc_id_pk_seq3'::regclass)");
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetailsArchive>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcArchIdPk).HasName("wfs_freeship_calculation_details_archive_pkey1");

            entity.Property(e => e.FreeshipCalcArchIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details__freeship_calc_arch_id_pk_seq1'::regclass)");
        });

        modelBuilder.Entity<WfsFreeshipCalculationDetailsArchive2018>(entity =>
        {
            entity.HasKey(e => e.FreeshipCalcArchIdPk).HasName("wfs_freeship_calculation_details_archive_pkey");

            entity.Property(e => e.FreeshipCalcArchIdPk).HasDefaultValueSql("nextval('wfs_freeship_calculation_details_a_freeship_calc_arch_id_pk_seq'::regclass)");
        });

        modelBuilder.Entity<WfsGenderMaster>(entity =>
        {
            entity.HasKey(e => e.GenderIdPk).HasName("wfs_gender_master_pkey");
        });

        modelBuilder.Entity<WfsInstitutionMaster>(entity =>
        {
            entity.HasKey(e => e.InstitutionIdPk).HasName("wfs_institution_master_pkey");

            entity.Property(e => e.ActiveStatus).HasDefaultValue((short)1);
            entity.Property(e => e.FeeStructureFlag).HasDefaultValue((short)0);
            entity.Property(e => e.MailSendStatus).HasDefaultValue((short)0);
            entity.Property(e => e.UpdateFlag).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<WfsMqMap>(entity =>
        {
            entity.HasKey(e => e.MqMapIdPk).HasName("wfs_mq_map_pkey3");

            entity.Property(e => e.MqMapIdPk).HasDefaultValueSql("nextval('wfs_mq_map_mq_map_id_pk_seq4'::regclass)");
        });

        modelBuilder.Entity<WfsMqMap2018>(entity =>
        {
            entity.HasKey(e => e.MqMapIdPk).HasName("wfs_mq_map_2018_pkey");

            entity.Property(e => e.MqMapIdPk).HasDefaultValueSql("nextval('wfs_mq_map_mq_map_id_pk_seq'::regclass)");
        });

        modelBuilder.Entity<WfsMqMap2019>(entity =>
        {
            entity.HasKey(e => e.MqMapIdPk).HasName("wfs_mq_map_pkey1");

            entity.Property(e => e.MqMapIdPk).HasDefaultValueSql("nextval('wfs_mq_map_mq_map_id_pk_seq1'::regclass)");
        });

        modelBuilder.Entity<WfsMqMap2020>(entity =>
        {
            entity.HasKey(e => e.MqMapIdPk).HasName("wfs_mq_map_pkey");

            entity.Property(e => e.MqMapIdPk).HasDefaultValueSql("nextval('wfs_mq_map_mq_map_id_pk_seq2'::regclass)");
        });

        modelBuilder.Entity<WfsMqMap2021>(entity =>
        {
            entity.HasKey(e => e.MqMapIdPk).HasName("wfs_mq_map_pkey2");

            entity.Property(e => e.MqMapIdPk).HasDefaultValueSql("nextval('wfs_mq_map_mq_map_id_pk_seq3'::regclass)");
        });

        modelBuilder.Entity<WfsMqMapBackup>(entity =>
        {
            entity.Property(e => e.MqMapIdPk).HasDefaultValueSql("nextval('wfs_mq_map_mq_map_id_fk_seq'::regclass)");
        });

        modelBuilder.Entity<WfsPrivilegeMaster>(entity =>
        {
            entity.HasKey(e => e.PrivilegeIdPk).HasName("wfs_privilege_master_pkey");

            entity.Property(e => e.ActiveStatus).HasDefaultValue(1);
        });

        modelBuilder.Entity<WfsQualifyingExamMaster>(entity =>
        {
            entity.HasKey(e => e.QualifyingExamIdPk).HasName("wfs_qualifying_exam_master_pkey");

            entity.Property(e => e.ActiveStatus).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<WfsStakeLevel>(entity =>
        {
            entity.HasKey(e => e.StakeLevelIdPk).HasName("wfs_stake_level_pkey");
        });

        modelBuilder.Entity<WfsStakeLevelType>(entity =>
        {
            entity.HasKey(e => e.StakeLevelTypeIdPk).HasName("wfs_stake_level_type_pkey");
        });

        modelBuilder.Entity<WfsStakeUserLogin>(entity =>
        {
            entity.HasKey(e => e.LoginIdPk).HasName("wfs_stake_user_login_pkey");

            entity.Property(e => e.ForgotPasswordFlag).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<WfsStatusMaster>(entity =>
        {
            entity.HasKey(e => e.StatusIdPk).HasName("wfs_status_master_pkey");
        });

        modelBuilder.Entity<WfsTwelfthStdBoardMaster>(entity =>
        {
            entity.HasKey(e => e.BoardIdPk).HasName("wfs_qualifying_exam_board_master_pkey");

            entity.Property(e => e.BoardIdPk).HasDefaultValueSql("nextval('wfs_qualifying_exam_board_master_board_id_pk_seq'::regclass)");
        });

        modelBuilder.Entity<WfsUploadDocument>(entity =>
        {
            entity.HasKey(e => e.UploadIdPk).HasName("wfs_upload_document_pkey");
        });

        modelBuilder.Entity<WfsVerificationDetail>(entity =>
        {
            entity.HasKey(e => e.UniversityRegistrationNo).HasName("wfs_verification_details_pkey2");

            entity.Property(e => e.VerificationIdPk).HasDefaultValueSql("nextval('wfs_verification_details_verification_id_pk_seq1'::regclass)");
        });

        modelBuilder.Entity<WfsVerificationDetailsBack1112>(entity =>
        {
            entity.Property(e => e.VerificationIdPk).HasDefaultValueSql("nextval('wfs_verification_details_verification_id_pk_seq'::regclass)");
        });

        modelBuilder.Entity<WfsVerificationDetailsBackup>(entity =>
        {
            entity.Property(e => e.VerificationIdPk).HasDefaultValueSql("nextval('wfs_verification_details_verification_id_pk_seq'::regclass)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
