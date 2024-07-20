using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_privilege_master")]
public partial class WfsPrivilegeMaster
{
    [Key]
    [Column("privilege_id_pk")]
    public long PrivilegeIdPk { get; set; }

    [Column("privilege_session")]
    [StringLength(20)]
    public string? PrivilegeSession { get; set; }

    [Column("privilege_name")]
    [StringLength(100)]
    public string? PrivilegeName { get; set; }

    [Column("privilege_path")]
    [StringLength(150)]
    public string? PrivilegePath { get; set; }

    [Column("stake_level_type_id_fk")]
    public int StakeLevelTypeIdFk { get; set; }

    [Column("stake_level_id_fk")]
    public int StakeLevelIdFk { get; set; }

    [Column("privilege_sub_menu_id")]
    public long? PrivilegeSubMenuId { get; set; }

    [Column("active_status")]
    public int ActiveStatus { get; set; }

    [Column("main_menu_icon")]
    [StringLength(155)]
    public string? MainMenuIcon { get; set; }

    [Column("privilege_priority")]
    public short? PrivilegePriority { get; set; }
}
