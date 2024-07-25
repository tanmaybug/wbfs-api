using System.ComponentModel.DataAnnotations.Schema;

namespace WbfsApi.DTO.v1
{
    public class DistrictResponseDTO
    {
        public long DistrictId { get; set; }
        public string? DistrictName { get; set; }
    }
}
