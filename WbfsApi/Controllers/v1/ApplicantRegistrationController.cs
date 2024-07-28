using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WbfsApi.DAL.Entities;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                myRes["Course"] = courseResponse;
                myRes["District"] = districtResponse;

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

        [HttpGet("TestRequest")]
        public IActionResult TestRequest()
        {
            String ApplicantID = "WBFS" + DateTime.Now.ToString("yyyyMMddHHmmssf");
            String Password = new PasswordGenerator().GenerateRandomPassword();
            string EnPassword = new CustomEncryption().Encrypt(Password);
            string DePassword = new CustomEncryption().Decrypt(EnPassword);
            string hashPassword = new CustomHashing().CreateHash(Password);
            bool vStat = new CustomHashing().VerifyHash(Password, hashPassword);

            string xh = new CustomHashing().CreateHash("1234");
            string yh = new CustomHashing().CreateHash("1234");


            return Ok(new { ApplicantID, Password, EnPassword, DePassword , hashPassword , vStat , xh ,yh});
        }
        
        [HttpPost("ApplicationRegistrationSubmit")]
        public async Task<IActionResult> ApplicationRegistrationSubmit([FromBody] ApplicationRegistrationRequestDTO RequestFromData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    String ApplicantID = "WBFS"+ DateTime.Now.ToString("yyyyMMddHHmmss");
                    String Password = new PasswordGenerator().GenerateRandomPassword();

                    var ApplicantData = new WfsApplicationDetail{
                        WfsRegistrationNo = ApplicantID,
                        ApplicantFname = RequestFromData.FirstName,
                        ApplicantMname = RequestFromData.MiddleName,
                        ApplicantLname = RequestFromData.LastName,
                        MobileNo = RequestFromData.MobileNumber,
                        EmailId = RequestFromData.EmailId,
                        TenthStdRollNo = RequestFromData.TenthRoll,
                        QualifyingExamName = RequestFromData.EntranceExam,
                        YearOfQualifyingExam = RequestFromData.EntranceExamYear,
                        PresentCourseName = RequestFromData.Course,
                        PresentCourseDiscipline = RequestFromData.Discipline,
                        PresentCourseDuration = RequestFromData.CourseDuration,
                        //DateOfAdmissionInPresentCourse = RequestFromData.DateOfAdmission,
                        PresentInstitutionName = RequestFromData.Institution,
                        InstitutionDistrictIdFk = RequestFromData.InstDistrict,
                        UniversityRegistrationNo = RequestFromData.UnivRegNo,
                        TwlfthPassingYear = RequestFromData.TwelfthExamYear,
                        TotalMarksObtainInTwlfthExam = RequestFromData.TwelfthObtainedMarks,
                        TotalMarksOfTwlfthExam = RequestFromData.TwelfthTotalMarks,
                        PercentageOfTwlfthExam = RequestFromData.TwelfthPercentage,
                        TwlfthStdRollNo = RequestFromData.TwelfthRoll,
                        TenthStdPassingYear = RequestFromData.TenthExamYear
                    };

                    var LoginData = new WfsStakeUserLogin
                    {
                        StakeLevelIdFk = 7,
                        StakeUser = ApplicantID,
                        StakePassword = new CustomHashing().CreateHash(Password),
                        ActiveStatus = 1
                    };

                    var TrackData = new WfsApplicationTrackHistory
                    {
                        WfsRegistrationIdFk = ApplicantID,
                        StakeLevelIdFk = 7,
                        TrackStatus = 4
                    };

                    var x = await _applicantRegRepo.RegistrationSubmit(ApplicantData, LoginData, TrackData);
                    if (x == null)
                    {
                        return BadRequest(new ApiResponse<string>
                        {
                            StatusCode = 400,
                            ResponseMessage = "Please Try Again",
                            ErrorStatus = true,
                            ResponseData = null
                        });
                    }

                    Dictionary<string, object?> myRes = [];
                    myRes["ApplicationID"] = ApplicantID;

                    var FinalResponse = new ApiResponse<object>
                    {
                        StatusCode = 200,
                        ResponseMessage = "Applicant Has Been Registered Successfully",
                        ErrorStatus = false,
                        ResponseData = myRes
                    };

                    return Ok(ApplicantData);
                }
                else
                {
                    return BadRequest(new ApiResponse<string>
                    {
                        StatusCode = 404,
                        ResponseMessage = "Please Enter Valida Data",
                        ErrorStatus = true,
                        ResponseData = null
                    });
                }
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
