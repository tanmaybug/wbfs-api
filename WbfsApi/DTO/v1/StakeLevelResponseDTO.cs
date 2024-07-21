using System.ComponentModel.DataAnnotations;

namespace WbfsApi.DTO.v1
{
    public class StakeLevelResponseDTO
    {
        [Required]
        public required int Stakelevelid { get; set; }

        [Required]
        public required string StakeLevelAbbreviation { get; set; }

        [Required]
        public required string Stakeleveldescription { get; set; }
    }
}
