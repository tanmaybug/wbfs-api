using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_freeship_calculation_details_archive_2018")]
public partial class WfsFreeshipCalculationDetailsArchive2018
{
    [Key]
    [Column("freeship_calc_arch_id_pk")]
    public long FreeshipCalcArchIdPk { get; set; }

    [Column("freeship_calc_id_pk")]
    public long? FreeshipCalcIdPk { get; set; }

    [Column("institution_id_fk")]
    public long? InstitutionIdFk { get; set; }

    [Column("course_id_fk")]
    public short? CourseIdFk { get; set; }

    [Column("descipline_id_fk")]
    public long? DesciplineIdFk { get; set; }

    [Column("wfs_registration_no_fk", TypeName = "character varying")]
    public string? WfsRegistrationNoFk { get; set; }

    [Column("freeship_type")]
    public short? FreeshipType { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip")]
    public string? EntryIp { get; set; }

    [Column("archive_entry_time", TypeName = "timestamp without time zone")]
    public DateTime? ArchiveEntryTime { get; set; }

    [Column("archive_entry_ip")]
    public string? ArchiveEntryIp { get; set; }
}
