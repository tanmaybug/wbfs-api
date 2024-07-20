using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_stake_user_login")]
public partial class WfsStakeUserLogin
{
    [Key]
    [Column("login_id_pk")]
    public long LoginIdPk { get; set; }

    [Column("stake_level_id_fk")]
    public long? StakeLevelIdFk { get; set; }

    [Column("stake_user")]
    [StringLength(255)]
    public string? StakeUser { get; set; }

    [Column("stake_password")]
    [StringLength(255)]
    public string? StakePassword { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }

    [Column("forgot_password_flag")]
    public short ForgotPasswordFlag { get; set; }
}
