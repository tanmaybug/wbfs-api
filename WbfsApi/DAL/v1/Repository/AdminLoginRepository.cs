using Microsoft.EntityFrameworkCore;
using WbfsApi.DAL.DBContext;
using WbfsApi.DAL.Entities;
using WbfsApi.DAL.v1.IRepository;

namespace WbfsApi.DAL.v1.Repository
{
    public class AdminLoginRepository : IAdminLoginRepository
    {
        private readonly WbfsDBContext _dbContext;
        public AdminLoginRepository(WbfsDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<WfsStakeLevel>?> GetStakeLevel()
        {
            var StakeData = await _dbContext.WfsStakeLevels.ToListAsync();

            if(StakeData ==  null)
            {
                return null;
            }
            return StakeData;
        }

        public async Task<WfsStakeUserLogin?> checkLogin(String Username , long StakeLevel)
        {
            if(Username == null)
            {
                return null;
            }

            var userdetails = await _dbContext.WfsStakeUserLogins.FirstOrDefaultAsync(x => x.StakeUser == Username && x.ActiveStatus == '1' && x.StakeLevelIdFk == StakeLevel);

            if (userdetails == null)
            {
                return null;
            }

            return userdetails;
        }
    }
}
