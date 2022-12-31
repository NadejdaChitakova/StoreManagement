using System.ComponentModel.DataAnnotations;

namespace AuthorizationAPI.Entity
{
    public class UserLoginDTO
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
