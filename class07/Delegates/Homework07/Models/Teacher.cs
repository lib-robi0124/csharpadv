namespace Homework07.Models
{
    public class Teacher 
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public delegate void SendNotification(string student);
        public event SendNotification OnSendNotification;
        public void NotifyStudent()
        {
            Console.WriteLine($"Teacher {Name} has sent a notification for {Subject}.");
            OnSendNotification?.Invoke($"Notification from {Name}: Class for {Subject} will start at 10 AM.");
        }
        public Teacher(string name, int age, string email, string subject)
        {
            Name = name;
            Age = age;
            Email = email;
            Subject = subject;
        }
        public void SubscribeToNotification(Student student)
        {
            OnSendNotification += student.GetNotification;
            Console.WriteLine($"{student.Name} subscribed to {Name}'s notifications.");
        }
        public void UnsubscribeFromNotification(Student student)
        {
            OnSendNotification -= student.GetNotification;
            Console.WriteLine($"{student.Name} unsubscribed from {Name}'s notifications.");
        }


    }
}
