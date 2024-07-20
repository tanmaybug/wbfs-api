using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities;

[Table("wfs_mq_map_2018")]
public partial class WfsMqMap2018
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
}
