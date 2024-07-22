using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WbfsApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantRegistrationController : ControllerBase
    {
        public ApplicantRegistrationController() { 
        }

        /*[HttpGet("ApplicantRegistrationFormData")]
        public Task<IActionResult> ApplicantRegistrationFormData()
        {
            //return BadRequest();
        }*/
    }
}
