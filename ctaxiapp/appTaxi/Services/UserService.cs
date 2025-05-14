

using Domain.Enums;
using Domain.Models;

namespace Services
{
    public static class UserService
    {
        private static List<User> _users = new();
        public static class UserService
        {
            private static List<User> _users;
            private static User? _loggedInUser;
            public static User? LoggedInUser
            {
                get => _loggedInUser;
                private set => _loggedInUser = value;
            }

            public static bool Login(string username, string password)
            {
                var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                {
                    LoggedInUser = user;
                    return true;
                }
                return false;
            }

            public static bool CreateUser(string username, string password, UserRole role)
            {
                if (username.Length < 5 || password.Length < 5 || !password.Any(char.IsDigit)) return false;
                if (_users.Any(u => u.Username == username))
                {
                    return false;
                }

                var newUser = new User
                {
                    Id = _users.Count + 1,
                    Username = username,
                    Password = password,
                    Role = role
                };

                _users.Add(newUser);
                return true;
            }

            public static List<User> GetAllUsers()
            {
                return _users;
            }
        }

        public static User? LoggedInUser { get; private set; }
        public static bool Login(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                LoggedInUser = user;
                return true;
            }
            return false;
        }
        public static bool CreateUser(string username, string password, UserRole role)
        {
            if (username.Length < 5 || password.Length < 5 || !password.Any(char.IsDigit)) return false;
            if (_users.Any(u => u.Username == username)) return false;

            _users.Add(new User
            {
                Id = _users.Count + 1,
                Username = username,
                Password = password,
                Role = role
            });
            return true;
        }
        public static List<User> GetAllUsers() => _users;
    }
}
