using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_district_master")]
public partial class WfsDistrictMaster
{
    [Key]
    [Column("district_id_pk")]
    public long DistrictIdPk { get; set; }

    [Column("district_code")]
    public short? DistrictCode { get; set; }

    [Column("district_name")]
    public string? DistrictName { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }
}
