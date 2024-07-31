using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.Entities;
using WbfsApi.DAL.v1.IRepository;
using WbfsApi.DTO.v1;

namespace WbfsApi.DAL.v1.Repository
{
    public class ApplicantRegistrationRepository : IApplicantRegistrationRepository
    {
        private readonly WbfsDBContext _dbContext;
        public ApplicantRegistrationRepository(WbfsDBContext dBContext) 
        {
            _dbContext = dBContext;
        }
        public async Task<List<WfsQualifyingExamMaster>?> GetQualifyingExams()
        {
            var examData = await _dbContext.WfsQualifyingExamMasters.Where(p => p.ActiveStatus==1).ToListAsync();

            if (examData == null)
            {
                return null;
            }
            return examData;
        }

        public async Task<List<WfsTwelfthStdBoardMaster>?> GetTwelfthStdBoards()
        {
            var boardData = await _dbContext.WfsTwelfthStdBoardMasters.Where(p => p.ActiveStatus == 1).ToListAsync();

            if (boardData == null)
            {
                return null;
            }
            return boardData;
        }

        public async Task<List<WfsCourseMaster>?> GetCourseMasters()
        {
            var courseData = await _dbContext.WfsCourseMasters.Where(p => p.ActiveStatus == 1).ToListAsync();

            if (courseData == null)
            {
                return null;
            }
            return courseData;
        }

        public async Task<List<WfsDistrictMaster>?> GetDistrictMasters()
        {
            var distData = await _dbContext.WfsDistrictMasters.Where(p => p.ActiveStatus == 1).ToListAsync();

            if (distData == null)
            {
                return null;
            }
            return distData;
        }

        public async Task<string?> GetUniqueApplicantId(String ApplicantId)
        {
            //var appIdData = await _dbContext.WfsApplicationDetails.FirstOrDefaultAsync(p => p.WfsRegistrationNo == ApplicantId);
            var appIdData = await _dbContext.WfsApplicationDetails.Where(p => p.WfsRegistrationNo == ApplicantId).ToListAsync();

            return appIdData?[0].WfsRegistrationNo;
        }

        public async Task<string> RegistrationSubmit(WfsApplicationDetail ApplicantData, WfsStakeUserLogin LoginData, WfsApplicationTrackHistory TrackData)
        {
            try
            {
                await _dbContext.WfsApplicationDetails.AddAsync(ApplicantData);
                await _dbContext.WfsStakeUserLogins.AddAsync(LoginData);
                await _dbContext.WfsApplicationTrackHistories.AddAsync(TrackData);
                _dbContext.SaveChanges();

                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
