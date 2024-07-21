using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WbfsApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrativeLoginController : ControllerBase
    {
        public AdministrativeLoginController() { 
        }

        [HttpGet("GetStakeLevel")]
        public async Task<IActionResult> GetStakeLevel()
        {
            return BadRequest();
        }
    }
}
