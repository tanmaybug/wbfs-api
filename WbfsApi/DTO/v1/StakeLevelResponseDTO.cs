using System.ComponentModel.DataAnnotations;

namespace WbfsApi.DTO.v1
{
    public class StakeLevelResponseDTO
    {
        [Required]
        public required long StakeLevelId { get; set; }

        [Required]
        public required string StakeLevelAbbreviation { get; set; }

        [Required]
        public required string StakeLevelDescription { get; set; }
    }
}
