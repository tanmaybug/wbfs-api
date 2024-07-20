using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_freeship_calculation_details")]
public partial class WfsFreeshipCalculationDetail
{
    [Key]
    [Column("freeship_calc_id_pk")]
    public long FreeshipCalcIdPk { get; set; }

    [Column("institution_id_fk")]
    public long? InstitutionIdFk { get; set; }

    [Column("course_id_fk")]
    public short? CourseIdFk { get; set; }

    [Column("descipline_id_fk")]
    public long? DesciplineIdFk { get; set; }

    [Column("wfs_registration_no_fk")]
    [StringLength(255)]
    public string? WfsRegistrationNoFk { get; set; }

    [Column("freeship_type")]
    public short? FreeshipType { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip")]
    public string? EntryIp { get; set; }
}
