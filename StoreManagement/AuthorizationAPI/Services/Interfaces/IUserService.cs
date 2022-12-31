using AuthorizationAPI.Entity;
using AuthorizationAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUser(UserDTO userDTO);
        Task<bool> Login(UserLoginDTO user);
    }
}
