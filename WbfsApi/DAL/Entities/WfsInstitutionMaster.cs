using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_institution_master")]
public partial class WfsInstitutionMaster
{
    [Column("district_id_fk")]
    public long? DistrictIdFk { get; set; }

    [Column("institution_name")]
    public string? InstitutionName { get; set; }

    [Column("institution_code", TypeName = "character varying")]
    public string? InstitutionCode { get; set; }

    [Column("active_status")]
    public short ActiveStatus { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip", TypeName = "character varying")]
    public string? EntryIp { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("hoi_name")]
    public string? HoiName { get; set; }

    [Column("hoi_mobile_no")]
    public long? HoiMobileNo { get; set; }

    [Column("district_id_new")]
    public long? DistrictIdNew { get; set; }

    [Column("hoi_office_phn")]
    [StringLength(12)]
    public string? HoiOfficePhn { get; set; }

    [Column("update_time", TypeName = "timestamp without time zone")]
    public DateTime? UpdateTime { get; set; }

    [Column("update_ip", TypeName = "character varying")]
    public string? UpdateIp { get; set; }

    [Key]
    [Column("institution_id_pk")]
    public long InstitutionIdPk { get; set; }

    [Column("mail_send_status")]
    public short MailSendStatus { get; set; }

    [Column("update_flag")]
    public short UpdateFlag { get; set; }

    [Column("fee_structure_flag")]
    public short FeeStructureFlag { get; set; }

    [Column("fee_structure_update_time", TypeName = "timestamp without time zone")]
    public DateTime? FeeStructureUpdateTime { get; set; }

    [Column("fee_structure_ip")]
    [StringLength(15)]
    public string? FeeStructureIp { get; set; }
}
