using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_application_track_history")]
public partial class WfsApplicationTrackHistory
{
    [Key]
    [Column("track_id_pk")]
    public long TrackIdPk { get; set; }

    [Column("wfs_registration_id_fk")]
    public string? WfsRegistrationIdFk { get; set; }

    [Column("track_time", TypeName = "timestamp without time zone")]
    public DateTime? TrackTime { get; set; }

    [Column("track_ip")]
    public string? TrackIp { get; set; }

    [Column("stake_level_id_fk")]
    public int? StakeLevelIdFk { get; set; }

    [Column("track_status")]
    public short? TrackStatus { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }
}
