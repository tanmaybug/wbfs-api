using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.DTO.v1;
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
                var TwelfthStdBoards = await _applicantRegRepo.GetTwelfthStdBoards();
                var CourseMasters = await _applicantRegRepo.GetCourseMasters();
                var DistrictMasters = await _applicantRegRepo.GetDistrictMasters();

                var examResponse = new List<QualifyingExamResponseDTO>();
                if(QualifyingExams != null)
                {
                    foreach (var exam in QualifyingExams)
                    {
                        var x = new QualifyingExamResponseDTO
                        {
                            ExamId = exam.QualifyingExamIdPk,
                            ExamName = exam.QualifyingExamName
                        };
                        examResponse.Add(x);
                    }
                }
                else
                {
                    examResponse = null;
                }

                var twelfthResponse = new List<TwelfthStdBoardResponseDTO>();
                if (TwelfthStdBoards != null)
                {
                    foreach (var board in TwelfthStdBoards)
                    {
                        var x = new TwelfthStdBoardResponseDTO
                        {
                            BoardId = board.BoardIdPk,
                            BoardName = board.BoardName
                        };
                        twelfthResponse.Add(x);
                    }
                }
                else
                {
                    twelfthResponse = null;
                }

                var courseResponse = new List<CourseResponseDTO>();
                if (CourseMasters != null)
                {
                    foreach (var course in CourseMasters)
                    {
                        var x = new CourseResponseDTO
                        {
                            CourseId = course.CourseIdPk,
                            CourseName = course.CourseName
                        };
                        courseResponse.Add(x);
                    }
                }
                else
                {
                    courseResponse = null;
                }

                var districtResponse = new List<DistrictResponseDTO>();
                if (DistrictMasters != null)
                {
                    foreach (var dist in DistrictMasters)
                    {
                        var x = new DistrictResponseDTO
                        {
                            DistrictId = dist.DistrictIdPk,
                            DistrictName = dist.DistrictName
                        };
                        districtResponse.Add(x);
                    }
                }
                else
                {
                    districtResponse = null;
                }

                Dictionary<string, object?> myRes = [];
                myRes["QualifyingExams"] = examResponse;
                myRes["TwelfthStdBoards"] = twelfthResponse;
                myRes["CourseMasters"] = courseResponse;
                myRes["DistrictMasters"] = districtResponse;

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
