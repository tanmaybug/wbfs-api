using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_twelfth_std_board_master")]
public partial class WfsTwelfthStdBoardMaster
{
    [Key]
    [Column("board_id_pk")]
    public long BoardIdPk { get; set; }

    [Column("board_name")]
    public string? BoardName { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }
}
