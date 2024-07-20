using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_course_discipline_map")]
public partial class WfsCourseDisciplineMap
{
    [Column("course_id_fk")]
    public long? CourseIdFk { get; set; }

    [Column("discipline_id_fk")]
    public long? DisciplineIdFk { get; set; }

    [Column("active_status")]
    public short ActiveStatus { get; set; }

    [Key]
    [Column("course_discipline_map_id_pk")]
    public long CourseDisciplineMapIdPk { get; set; }
}
