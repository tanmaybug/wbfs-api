using System.ComponentModel.DataAnnotations.Schema;

namespace WbfsApi.DTO.v1
{
    public class QualifyingExamResponseDTO
    {
        public long ExamId { get; set; }
        public required string ExamName { get; set; }
    }
}
