namespace Homework03.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int number { get; set; } // Added 'number' property to match the method signature
        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

     }
}
