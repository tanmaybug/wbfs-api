using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_mq_map")]
public partial class WfsMqMap
{
    [Key]
    [Column("mq_map_id_pk")]
    public long MqMapIdPk { get; set; }

    [Column("institution_id_fk")]
    public long? InstitutionIdFk { get; set; }

    [Column("course_id_fk")]
    public short? CourseIdFk { get; set; }

    [Column("descipline_id_fk")]
    public long? DesciplineIdFk { get; set; }

    [Column("total_applicant_in_mq")]
    public short? TotalApplicantInMq { get; set; }

    [Column("total_admitted_applicant")]
    public short? TotalAdmittedApplicant { get; set; }

    [Column("active_status")]
    public short? ActiveStatus { get; set; }

    [Column("entry_time", TypeName = "timestamp without time zone")]
    public DateTime? EntryTime { get; set; }

    [Column("entry_ip")]
    [StringLength(15)]
    public string? EntryIp { get; set; }

    [Column("update_time", TypeName = "timestamp without time zone")]
    public DateTime? UpdateTime { get; set; }

    [Column("update_ip")]
    [StringLength(15)]
    public string? UpdateIp { get; set; }
}
