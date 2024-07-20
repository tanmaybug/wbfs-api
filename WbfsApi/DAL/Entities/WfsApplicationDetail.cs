using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_application_details")]
public partial class WfsApplicationDetail
{
    [Key]
    [Column("wfs_registration_no")]
    public string WfsRegistrationNo { get; set; } = null!;

    [Column("applicant_fname")]
    public string? ApplicantFname { get; set; }

    [Column("applicant_mname")]
    public string? ApplicantMname { get; set; }

    [Column("applicant_lname")]
    public string? ApplicantLname { get; set; }

    [Column("mobile_no")]
    public long? MobileNo { get; set; }

    [Column("email_id")]
    public string? EmailId { get; set; }

    [Column("tenth_std_roll_no")]
    public string? TenthStdRollNo { get; set; }

    [Column("qualifying_exam_name")]
    public short? QualifyingExamName { get; set; }

    [Column("year_of_qualifying_exam")]
    public short? YearOfQualifyingExam { get; set; }

    [Column("present_course_name")]
    public short? PresentCourseName { get; set; }

    [Column("present_course_discipline")]
    public int? PresentCourseDiscipline { get; set; }

    [Column("present_course_duration")]
    public short? PresentCourseDuration { get; set; }

    [Column("date_of_admission_in_present_course")]
    public DateOnly? DateOfAdmissionInPresentCourse { get; set; }

    [Column("present_institution_name")]
    public short? PresentInstitutionName { get; set; }

    [Column("institution_district_id_fk")]
    public int? InstitutionDistrictIdFk { get; set; }

    [Column("father_fname")]
    public string? FatherFname { get; set; }

    [Column("father_mname")]
    public string? FatherMname { get; set; }

    [Column("father_lname")]
    public string? FatherLname { get; set; }

    [Column("mother_fname")]
    public string? MotherFname { get; set; }

    [Column("mother_mname")]
    public string? MotherMname { get; set; }

    [Column("mother_lname")]
    public string? MotherLname { get; set; }

    [Column("profession_of_father")]
    public string? ProfessionOfFather { get; set; }

    [Column("profession_of_mother")]
    public string? ProfessionOfMother { get; set; }

    [Column("gurdian_fname")]
    public string? GurdianFname { get; set; }

    [Column("gurdian_mname")]
    public string? GurdianMname { get; set; }

    [Column("gurdian_lname")]
    public string? GurdianLname { get; set; }

    [Column("profession_of_gurdian")]
    public string? ProfessionOfGurdian { get; set; }

    [Column("sex")]
    public short? Sex { get; set; }

    [Column("applicant_address")]
    public string? ApplicantAddress { get; set; }

    [Column("applicant_district")]
    public int? ApplicantDistrict { get; set; }

    [Column("total_family_income")]
    public long? TotalFamilyIncome { get; set; }

    [Column("applicant_password")]
    public string? ApplicantPassword { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip")]
    public string? EntryIp { get; set; }

    [Column("update_time", TypeName = "timestamp without time zone")]
    public DateTime? UpdateTime { get; set; }

    [Column("update_ip")]
    public string? UpdateIp { get; set; }

    [Column("applicant_dob")]
    public DateOnly? ApplicantDob { get; set; }

    [Column("institution_verification_remarks", TypeName = "character varying")]
    public string? InstitutionVerificationRemarks { get; set; }

    [Column("institution_verification_ip", TypeName = "character varying")]
    public string? InstitutionVerificationIp { get; set; }

    [Column("institution_verification_time", TypeName = "timestamp without time zone")]
    public DateTime? InstitutionVerificationTime { get; set; }

    [Column("institution_rejection_cause", TypeName = "character varying")]
    public string? InstitutionRejectionCause { get; set; }

    [Column("merit_rank")]
    public long? MeritRank { get; set; }

    [Column("application_status")]
    public short? ApplicationStatus { get; set; }

    [Column("tenth_std_passing_year")]
    public short? TenthStdPassingYear { get; set; }

    [Column("form_status")]
    public short? FormStatus { get; set; }

    [Column("receipt_twf")]
    public short? ReceiptTwf { get; set; }

    [Column("applied_svmcm")]
    public short? AppliedSvmcm { get; set; }

    [Column("phone_no")]
    public string? PhoneNo { get; set; }

    [Column("scholarship_id")]
    public string? ScholarshipId { get; set; }

    [Column("application_final_submission_date", TypeName = "timestamp without time zone")]
    public DateTime? ApplicationFinalSubmissionDate { get; set; }

    [Column("application_final_submission_ip")]
    public string? ApplicationFinalSubmissionIp { get; set; }

    [Column("forwarded_by", TypeName = "character varying")]
    public string? ForwardedBy { get; set; }

    [Column("applicant_declaration_status")]
    public short? ApplicantDeclarationStatus { get; set; }

    [Column("forgot_password_flag")]
    public short? ForgotPasswordFlag { get; set; }

    [Column("da_verification_remarks", TypeName = "character varying")]
    public string? DaVerificationRemarks { get; set; }

    [Column("da_verification_ip", TypeName = "character varying")]
    public string? DaVerificationIp { get; set; }

    [Column("da_verification_time", TypeName = "timestamp without time zone")]
    public DateTime? DaVerificationTime { get; set; }

    [Column("da_rejection_cause", TypeName = "character varying")]
    public string? DaRejectionCause { get; set; }

    [Column("ha_verification_remarks", TypeName = "character varying")]
    public string? HaVerificationRemarks { get; set; }

    [Column("ha_verification_ip", TypeName = "character varying")]
    public string? HaVerificationIp { get; set; }

    [Column("ha_verification_time", TypeName = "timestamp without time zone")]
    public DateTime? HaVerificationTime { get; set; }

    [Column("ha_rejection_cause", TypeName = "character varying")]
    public string? HaRejectionCause { get; set; }

    [Column("adte_verification_remarks", TypeName = "character varying")]
    public string? AdteVerificationRemarks { get; set; }

    [Column("adte_verification_ip", TypeName = "character varying")]
    public string? AdteVerificationIp { get; set; }

    [Column("adte_verification_time", TypeName = "timestamp without time zone")]
    public DateTime? AdteVerificationTime { get; set; }

    [Column("adte_rejection_cause", TypeName = "character varying")]
    public string? AdteRejectionCause { get; set; }

    [Column("ddte_verification_remarks", TypeName = "character varying")]
    public string? DdteVerificationRemarks { get; set; }

    [Column("ddte_verification_time", TypeName = "timestamp without time zone")]
    public DateTime? DdteVerificationTime { get; set; }

    [Column("ddte_verification_ip", TypeName = "character varying")]
    public string? DdteVerificationIp { get; set; }

    [Column("ddte_rejection_cause", TypeName = "character varying")]
    public string? DdteRejectionCause { get; set; }

    [Column("admission_rank_type")]
    public short? AdmissionRankType { get; set; }

    [Column("dte_verification_ip", TypeName = "character varying")]
    public string? DteVerificationIp { get; set; }

    [Column("dte_verification_time", TypeName = "timestamp without time zone")]
    public DateTime? DteVerificationTime { get; set; }

    [Column("dte_rejection_cause", TypeName = "character varying")]
    public string? DteRejectionCause { get; set; }

    [Column("twlfth_std_board_name")]
    public short? TwlfthStdBoardName { get; set; }

    [Column("twlfth_passing_year")]
    public short? TwlfthPassingYear { get; set; }

    [Column("total_marks_obtain_in_twlfth_exam")]
    public int? TotalMarksObtainInTwlfthExam { get; set; }

    [Column("total_marks_of_twlfth_exam")]
    public int? TotalMarksOfTwlfthExam { get; set; }

    [Column("percentage_of_twlfth_exam")]
    [Precision(4, 2)]
    public decimal? PercentageOfTwlfthExam { get; set; }

    [Column("other_twlfth_std_board_name", TypeName = "character varying")]
    public string? OtherTwlfthStdBoardName { get; set; }

    [Column("twlfth_std_roll_no")]
    public string? TwlfthStdRollNo { get; set; }

    [Column("university_registration_no")]
    public string? UniversityRegistrationNo { get; set; }

    [Column("allow_status")]
    public short AllowStatus { get; set; }

    [Column("year_of_apply")]
    public short? YearOfApply { get; set; }
}
