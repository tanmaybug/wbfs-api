using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_gender_master")]
public partial class WfsGenderMaster
{
    [Key]
    [Column("gender_id_pk")]
    public long GenderIdPk { get; set; }

    [Column("gender_name")]
    public string? GenderName { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }
}
