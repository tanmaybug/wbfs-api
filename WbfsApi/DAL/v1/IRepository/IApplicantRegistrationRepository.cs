using WbfsApi.DAL.Entities;

namespace WbfsApi.DAL.v1.IRepository
{
    public interface IApplicantRegistrationRepository
    {
        Task<List<WfsQualifyingExamMaster>?> GetQualifyingExams();

        Task<List<WfsTwelfthStdBoardMaster>?> GetWfsTwelfthStdBoards();

        Task<List<WfsCourseMaster>> GetCourseMasters();

        Task<List<WfsDistrictMaster>?> GetDistrictMasters();
    }
}
