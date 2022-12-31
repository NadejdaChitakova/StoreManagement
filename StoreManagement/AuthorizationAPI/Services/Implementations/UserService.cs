using AuthorizationAPI.Entity;
using AuthorizationAPI.Models;
using AuthorizationAPI.Services.Interfaces;
using DatabaseShemaManager.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DBContext _dBContext;

        public UserService(DBContext dBContext) { 
            _dBContext= dBContext;
        }
        Task<User> CreateUser(UserDTO userDTO)
        {
            if (userDTO.Username == null || userDTO.Email == null || userDTO.Password == null)
            {
                return null;
            }


        }

        Task<IActionResult> IUserService.Login(UserLoginDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
