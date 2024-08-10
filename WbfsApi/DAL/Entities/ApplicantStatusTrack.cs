using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WbfsApi.DAL.Entities
{
    [Keyless]
    public class ApplicantStatusTrack
    {
        [Column("track_time", TypeName = "timestamp without time zone")]
        public DateTime? TrackTime { get; set; }

        [Column("status_id_pk")]
        public long StatusIdPk { get; set; }

        [Column("description")]
        public string? Description { get; set; }
    }
}
