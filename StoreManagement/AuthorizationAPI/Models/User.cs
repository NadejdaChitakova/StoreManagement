using System.ComponentModel.DataAnnotations;

namespace AuthorizationAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(15), MinLength(5)]
        public string Username { get; set; }

        [MaxLength(20), MinLength(6)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public string? Phone { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }
    }
}
