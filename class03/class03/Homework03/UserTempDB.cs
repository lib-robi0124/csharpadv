using Homework03.Models;

namespace Homework03
{
    public class UserTempDB
    {
        public static List<User> Users { get; set; } = new List<User>();
        static UserTempDB() // Removed 'public' access modifier to fix CS0515
        {
            Users = new List<User>()
            {
                new User(1, "Alice", 30),
                new User(2, "Bob", 25),
                new User(3, "Charlie", 35)
            };
        }
        public static void PrintAllUsers()
        {
            foreach (User user in Users)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
        }
        public static List<User> Search(int? id = null, string name = null, int? age = null)
        {
            return Users.Where(user =>
                (!id.HasValue || user.Id == id.Value) &&
                (string.IsNullOrEmpty(name) || user.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) &&
                (!age.HasValue || user.Age == age.Value)).ToList();
        }
    }
}
