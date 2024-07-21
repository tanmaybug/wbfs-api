using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
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

        public async Task<WfsStakeUserLogin?> CheckUserData(string Username)
        {
            if (Username == null)
            {
                return null;
            }

            var userdetails =  await _dbContext.WfsStakeUserLogins.FirstOrDefaultAsync(x => x.StakeUser == Username && x.ActiveStatus=='1');

            if (userdetails == null) {
                return null;
            }

            return userdetails;
        }
    }
}
