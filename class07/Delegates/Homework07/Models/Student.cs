namespace Homework07.Models
{
    public class Student
    {
     
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public void GetNotification(string text)
         {
            Console.WriteLine($"Student {Name} has received {text} sa notification.");
        }
        public Student(string name, int age, string email, string subject)
        {
            Name = name;
            Age = age;
            Email = email;
            Subject = subject;
        }

        public Student()
        {
        }
    }
}
