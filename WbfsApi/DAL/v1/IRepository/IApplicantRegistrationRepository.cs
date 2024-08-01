using WbfsApi.DAL.Entities;
using WbfsApi.DTO.v1;

namespace WbfsApi.DAL.v1.IRepository
{
    public interface IApplicantRegistrationRepository
    {
        Task<List<WfsQualifyingExamMaster>?> GetQualifyingExams();

        Task<List<WfsTwelfthStdBoardMaster>?> GetTwelfthStdBoards();

        Task<List<WfsCourseMaster>?> GetCourseMasters();

        Task<List<WfsDistrictMaster>?> GetDistrictMasters();

        Task<string?> GetUniqueApplicantId(String ApplicantId);

        Task<string> RegistrationSubmit(WfsApplicationDetail ApplicantData, WfsStakeUserLogin LoginData, WfsApplicationTrackHistory TrackData);
    }
}
