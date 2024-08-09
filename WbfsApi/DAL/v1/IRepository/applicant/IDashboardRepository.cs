using WbfsApi.DAL.Entities;
using WbfsApi.DTO.v1;

namespace WbfsApi.DAL.v1.IRepository.applicant
{
    public interface IDashboardRepository
    {
        Task<WfsApplicationDetail?> GetApplicantDetails(String ApplicantID);
        Task<List<ApplicantStatusTrackResponseDTO>?> GetApplicantStatusTrackDetails(String ApplicantID);
    }
}
