using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.Helpers;

namespace WbfsApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantRegistrationController : ControllerBase
    {
        private readonly IApplicantRegistrationRepository _applicantRegRepo;
        public ApplicantRegistrationController(IApplicantRegistrationRepository ApplicantRegRepo) 
        {
            _applicantRegRepo = ApplicantRegRepo;
        }

        [HttpGet("ApplicantRegistrationFormData")]
        public async Task<IActionResult> ApplicantRegistrationFormData()
        {
            try
            {
                var QualifyingExams = await _applicantRegRepo.GetQualifyingExams();
                /*var TwelfthStdBoards = await _applicantRegRepo.GetTwelfthStdBoards();
                var CourseMasters = await _applicantRegRepo.GetCourseMasters();
                var DistrictMasters = await _applicantRegRepo.GetDistrictMasters();*/

                Dictionary<string, object?> myRes = [];
                myRes["QualifyingExams"] = QualifyingExams;
                /*myRes["TwelfthStdBoards"] = TwelfthStdBoards;
                myRes["CourseMasters"] = CourseMasters;
                myRes["DistrictMasters"] = DistrictMasters;*/

                var FinalResponse = new ApiResponse<object>
                {
                    StatusCode = 200,
                    ResponseMessage = "Applicant Registration Form Data",
                    ErrorStatus = false,
                    ResponseData = myRes
                };

                return Ok(FinalResponse);
            }
            catch (Exception ex) {
                return BadRequest(new ApiResponse<string>
                {
                    StatusCode = 404,
                    ResponseMessage = ex.Message,
                    ErrorStatus = true,
                    ResponseData = null
                });
            }
        }
    }
}
