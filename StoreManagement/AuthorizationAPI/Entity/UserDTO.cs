using System.ComponentModel.DataAnnotations;

namespace AuthorizationAPI.Entity
{
    public class UserDTO
    {
        public int Id { get; set; }

        [MaxLength(15), MinLength(5)]
        public string Username { get; set; }

        [MaxLength(20), MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string? Phone { get; set; }
    }
}
