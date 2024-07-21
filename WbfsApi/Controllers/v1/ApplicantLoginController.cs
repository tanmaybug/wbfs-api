using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.DTO.v1;

namespace WbfsApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantLoginController : ControllerBase
    {
        private readonly IApplicantLoginRepository _loginRepo;
        public ApplicantLoginController(IApplicantLoginRepository loginRepo)
        {
            _loginRepo = loginRepo;
        }

        [HttpPost("ApplicantLogin")]
        public async Task<IActionResult> Login([FromBody] ApplicantLoginRequestDTO loginData)
        {
            try
            {
                if(ModelState.IsValid) 
                {
                    var userData = await _loginRepo.CheckUserData(loginData.Username);
                    if (userData == null)
                    {
                        return NotFound();
                    }
                    return Ok(userData);
                }else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
