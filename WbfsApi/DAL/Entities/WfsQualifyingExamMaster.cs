using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_qualifying_exam_master")]
public partial class WfsQualifyingExamMaster
{
    [Key]
    [Column("qualifying_exam_id_pk")]
    public long QualifyingExamIdPk { get; set; }

    [Column("qualifying_exam_name")]
    public required string QualifyingExamName { get; set; }

    [Column("active_status")]
    public short ActiveStatus { get; set; }
}
