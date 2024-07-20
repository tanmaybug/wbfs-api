using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Keyless]
[Table("wfs_verification_details_backup")]
public partial class WfsVerificationDetailsBackup
{
    [Column("verification_id_pk")]
    public long VerificationIdPk { get; set; }

    [Column("university_registration_no")]
    public string UniversityRegistrationNo { get; set; } = null!;

    [Column("applicant_fname")]
    public string? ApplicantFname { get; set; }

    [Column("applicant_mname")]
    public string? ApplicantMname { get; set; }

    [Column("applicant_lname")]
    public string? ApplicantLname { get; set; }

    [Column("present_course_name")]
    public short? PresentCourseName { get; set; }

    [Column("present_course_discipline")]
    public int? PresentCourseDiscipline { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip")]
    [StringLength(15)]
    public string? EntryIp { get; set; }

    [Column("present_institution_name")]
    public int? PresentInstitutionName { get; set; }

    [Column("institution_district_id_fk")]
    public int? InstitutionDistrictIdFk { get; set; }
}
