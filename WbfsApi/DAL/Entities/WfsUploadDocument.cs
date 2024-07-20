using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_upload_document")]
public partial class WfsUploadDocument
{
    [Key]
    [Column("upload_id_pk")]
    public long UploadIdPk { get; set; }

    [Column("applicant_photograph")]
    public string? ApplicantPhotograph { get; set; }

    [Column("applicant_signature")]
    public string? ApplicantSignature { get; set; }

    [Column("income_certificate")]
    public string? IncomeCertificate { get; set; }

    [Column("domicil_certificate")]
    public string? DomicilCertificate { get; set; }

    [Column("merit_rank_card")]
    public string? MeritRankCard { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip")]
    public string? EntryIp { get; set; }

    [Column("update_time", TypeName = "timestamp without time zone")]
    public DateTime? UpdateTime { get; set; }

    [Column("update_ip")]
    public string? UpdateIp { get; set; }

    [Column("wfs_registration_no_fk")]
    public string? WfsRegistrationNoFk { get; set; }

    [Column("admit_of_twlfth_std")]
    public string? AdmitOfTwlfthStd { get; set; }

    [Column("marksheet_of_twlfth_std")]
    public string? MarksheetOfTwlfthStd { get; set; }

    [Column("applicant_photograph_bytea")]
    public byte[]? ApplicantPhotographBytea { get; set; }

    [Column("applicant_signature_bytea")]
    public byte[]? ApplicantSignatureBytea { get; set; }

    [Column("income_certificate_bytea")]
    public byte[]? IncomeCertificateBytea { get; set; }

    [Column("domicil_certificate_bytea")]
    public byte[]? DomicilCertificateBytea { get; set; }

    [Column("merit_rank_card_bytea")]
    public byte[]? MeritRankCardBytea { get; set; }

    [Column("admit_of_twlfth_std_bytea")]
    public byte[]? AdmitOfTwlfthStdBytea { get; set; }

    [Column("marksheet_of_twlfth_std_bytea")]
    public byte[]? MarksheetOfTwlfthStdBytea { get; set; }
}
