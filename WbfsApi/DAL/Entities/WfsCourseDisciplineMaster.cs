using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_course_discipline_master")]
public partial class WfsCourseDisciplineMaster
{
    [Column("name_of_discipline", TypeName = "character varying")]
    public string? NameOfDiscipline { get; set; }

    [Key]
    [Column("discipline_id_pk")]
    public long DisciplineIdPk { get; set; }
}
