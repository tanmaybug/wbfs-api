using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.DTO.v1;
using WbfsApi.Helpers;

namespace WbfsApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministrativeLoginController : ControllerBase
    {
        private readonly IAdminLoginRepository _adminLoginRepo;
        public AdministrativeLoginController(IAdminLoginRepository adminLoginRepo) 
        {
            _adminLoginRepo = adminLoginRepo;
        }

        [HttpGet("GetStakeLevel")]
        public async Task<IActionResult> GetStakeLevel()
        {
            try
            {
                var stakeList = await _adminLoginRepo.GetStakeLevel();

                if(stakeList == null)
                {
                    return BadRequest();
                }

                var stakeResponse = new List<StakeLevelResponseDTO>();
                foreach (var stake in stakeList)
                {
                    var x = new StakeLevelResponseDTO
                    {
                        StakeLevelId = stake.StakeLevelIdPk,
                        StakeLevelAbbreviation = stake.StakeLevelAbbreviation,
                        StakeLevelDescription = stake.StakeLevelDescription
                    };
                    stakeResponse.Add(x);
                }

                var FinalResponse = new APIResponse
                {
                    StatusCode = 200,
                    ResponseMessage = "Stake Level Data",
                    //ResponseData = stakeResponse
                };

                return Ok(FinalResponse);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AdminLogin")]
        public async Task<IActionResult> AdminLogin([FromBody] AdminLoginRequestDTO LoginData)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var AdminData = await _adminLoginRepo.checkLogin(LoginData.Username,LoginData.StakeLevel);
                    if(AdminData == null) { 
                        return BadRequest();
                    }
                    return Ok(AdminData);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
