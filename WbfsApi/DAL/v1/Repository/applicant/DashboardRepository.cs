using Microsoft.EntityFrameworkCore;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.Entities;
using WbfsApi.DAL.v1.IRepository.applicant;

namespace WbfsApi.DAL.v1.Repository.applicant
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly WbfsDBContext _dbContext;
        public DashboardRepository(WbfsDBContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public async Task<WfsApplicationDetail?> GetApplicantDetails(String ApplicantID)
        {
            var applicantData = await _dbContext.WfsApplicationDetails.FirstOrDefaultAsync(p => p.WfsRegistrationNo == ApplicantID);
            if (applicantData == null)
            {
                return null;
            }
            return applicantData;
        }
    }
}
