using System.ComponentModel.DataAnnotations;

namespace WbfsApi.DTO.v1
{
    public class ApplicantLoginRequestDTO
    {
        [Required]
        public required String Username { get; set; }

        [Required]
        public required String Password { get; set; }
    }
}
