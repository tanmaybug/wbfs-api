using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_status_master")]
public partial class WfsStatusMaster
{
    [Key]
    [Column("status_id_pk")]
    public long StatusIdPk { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }

    [Column("status_priority")]
    public short? StatusPriority { get; set; }
}
