using WbfsApi.DAL.Entities;

namespace WbfsApi.DAL.v1.IRepository
{
    public interface IAdminLoginRepository
    {
        Task<List<WfsStakeLevel>?> GetStakeLevel();

        Task<WfsStakeUserLogin?> checkLogin(String Username, long StakeLevel); 
    }
}
