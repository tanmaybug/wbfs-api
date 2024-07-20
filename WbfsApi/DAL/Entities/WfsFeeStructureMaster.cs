using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_fee_structure_master")]
public partial class WfsFeeStructureMaster
{
    [Key]
    [Column("fee_structure_id_pk")]
    public long FeeStructureIdPk { get; set; }

    [Column("description", TypeName = "character varying")]
    public string? Description { get; set; }

    [Column("active_status")]
    public short ActiveStatus { get; set; }
}
