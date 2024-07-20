using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_stake_level_type")]
public partial class WfsStakeLevelType
{
    [Key]
    [Column("stake_level_type_id_pk")]
    public long StakeLevelTypeIdPk { get; set; }

    [Column("stake_level_type_name")]
    [StringLength(100)]
    public string? StakeLevelTypeName { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }
}
