using Microsoft.EntityFrameworkCore;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.Entities;
using WbfsApi.DAL.v1.IRepository;

namespace WbfsApi.DAL.v1.Repository
{
    public class ApplicantLoginRepository : IApplicantLoginRepository
    {
        private readonly WbfsDBContext _dbContext;
        public ApplicantLoginRepository(WbfsDBContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<List<WfsStakeUserLogin>> CheckUserData(string Username)
        {
            /*if(Username == null) {
                return 
            }*/
            
            return await _dbContext.WfsStakeUserLogins.ToListAsync();
        }
    }
}
