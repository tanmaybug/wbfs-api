using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_stake_level")]
public partial class WfsStakeLevel
{
    [Key]
    [Column("stake_level_id_pk")]
    public long StakeLevelIdPk { get; set; }

    [Column("stake_level_abbreviation")]
    [StringLength(255)]
    public string? StakeLevelAbbreviation { get; set; }

    [Column("stake_level_description")]
    [StringLength(255)]
    public string? StakeLevelDescription { get; set; }

    [Column("stake_level_master_pass")]
    [StringLength(255)]
    public string? StakeLevelMasterPass { get; set; }

    [Column("stake_level_type_id_fk")]
    public int? StakeLevelTypeIdFk { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }
}
