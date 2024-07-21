using System.ComponentModel.DataAnnotations;

namespace WbfsApi.DTO.v1
{
    public class AdminLoginRequestDTO
    {
        [Required]
        public required long StakeLevel { get; set; }

        [Required]
        public required String Username { get; set; }

        [Required]
        public required String Password { get; set; }
    }
}
