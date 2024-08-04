using WbfsApi.DAL.Entities;

namespace WbfsApi.DAL.v1.IRepository.applicant
{
    public interface IDashboardRepository
    {
        Task<WfsApplicationDetail?> GetApplicantDetails(String ApplicantID);
    }
}
