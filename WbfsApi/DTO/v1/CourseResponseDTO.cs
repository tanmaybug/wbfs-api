using System.ComponentModel.DataAnnotations.Schema;

namespace WbfsApi.DTO.v1
{
    public class CourseResponseDTO
    {
        public long CourseId { get; set; }
        public string? CourseName { get; set; }
    }
}
