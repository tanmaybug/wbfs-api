using Microsoft.AspNetCore.Mvc;
using WbfsApi.DAL.Entities;

namespace WbfsApi.DAL.v1.IRepository
{
    public interface IApplicantLoginRepository
    {
        Task<WfsStakeUserLogin?> CheckUserData(string Username);
    }
}
