using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_course_master")]
public partial class WfsCourseMaster
{
    [Key]
    [Column("course_id_pk")]
    public long CourseIdPk { get; set; }

    [Column("course_name")]
    public string? CourseName { get; set; }

    [Column("active_status")]
    public short ActiveStatus { get; set; }

    [Column("course_duration")]
    public double? CourseDuration { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip", TypeName = "character varying")]
    public string? EntryIp { get; set; }
}
