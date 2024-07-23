using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.Entities;
using WbfsApi.DAL.v1.IRepository;

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
    }
}
