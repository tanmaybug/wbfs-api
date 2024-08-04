namespace WbfsApi.DAL.v1.IRepository.applicant
{
    public interface IDashboardRepository
    {
        Task<String> GetApplicantDetails();
    }
}
