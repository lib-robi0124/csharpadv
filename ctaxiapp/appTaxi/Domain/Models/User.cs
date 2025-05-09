using Domain.Enums;

namespace Domain.Models
{
    public class User : BaseEntity
    {
        public User() { } // Parameterless constructor for EF Core
        public User(string username, string password, UserRole role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } // e.g., Admin, User, etc.

        public override string Print()
        {
            return $"{Username} with the role of {Role}";
        }
    }
}
