using System.ComponentModel.DataAnnotations.Schema;

namespace WbfsApi.DTO.v1
{
    public class TwelfthStdBoardResponseDTO
    {
        public long BoardId { get; set; }
        public string? BoardName { get; set; }
    }
}
