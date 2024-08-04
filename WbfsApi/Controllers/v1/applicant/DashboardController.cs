using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WbfsApi.DAL.v1.IRepository.applicant;
using WbfsApi.Helpers;

namespace WbfsApi.Controllers.v1.applicant
{
    [Route("api/applicant/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly String ApplicantID = "WBFS2121";
        private readonly IDashboardRepository _dashboardRepo;
        public DashboardController(IDashboardRepository dashboardRepo) 
        {
            _dashboardRepo = dashboardRepo;
        }

        [HttpGet]
        public async Task<IActionResult> ApplicantDashboard()
        {
            try
            {
                var applicantData = await _dashboardRepo.GetApplicantDetails(ApplicantID);

                Dictionary<string, object?> myRes = [];
                myRes["ApplicationID"] = ApplicantID;
                myRes["ApplicationName"] = applicantData?.ApplicantFname;
                myRes["Status"] = "Registration Done";

                Dictionary<string, string?> Activityinfo = [];
                Activityinfo["ApplicantRegistration"] = "01-01-2024";
                Activityinfo["ApplicationFormFillup"] = "01-01-2024";
                Activityinfo["UploadSupportingDocument"] = null;
                Activityinfo["FinalSubmissionofApplication"] = null;

                myRes["Activity"] = Activityinfo;

                var FinalResponse = new ApiResponse<object>
                {
                    StatusCode = 200,
                    ResponseMessage = "Applicant Dashboard Data",
                    ErrorStatus = false,
                    ResponseData = myRes
                };

                return Ok(FinalResponse);
            }catch (Exception ex)
            {
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
