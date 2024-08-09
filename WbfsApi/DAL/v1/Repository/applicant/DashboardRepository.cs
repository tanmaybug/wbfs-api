using Microsoft.EntityFrameworkCore;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.Entities;
using WbfsApi.DAL.v1.IRepository.applicant;
using WbfsApi.DTO.v1;

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

        public async Task<List<ApplicantStatusTrackResponseDTO>?> GetApplicantStatusTrackDetails(String ApplicantID)
        {
            var query = @"
            select t.track_time as TrackTime,s.status_id_pk as StatusID,s.description as Status 
            from wfs_application_track_history as t join wfs_status_master as s 
            on t.track_status=s.status_id_pk
            where t.wfs_registration_id_fk='WFS181551267173'
            order by t.track_time";

            var result = await _dbContext.Set<ApplicantStatusTrackResponseDTO>().FromSqlRaw(query).ToListAsync();

            if(result == null)
            {
                return null;
            }
            return result;
        }
    }
}
