
using Homework07.Models;

class Program
{
    static void Main(string[] args)
    {
        //Provide the required arguments for the Teacher constructor.
        Teacher professor = new Teacher("Professor Robert", 45, "robert@school.com", "Math");

        //Provide the required arguments for the Student constructor.
        Student s1 = new() { Name = "Alice", Age = 18, Email = "alice@student.com", Subject = "Math" };
        Student s2 = new() { Name = "Bob", Age = 19, Email = "bob@student.com", Subject = "Math" };
        Student s3 = new() { Name = "Charlie", Age = 20, Email = "charlie@student.com", Subject = "Math" };

        // Subscribe students to the teacher's notifications
        Console.ForegroundColor = ConsoleColor.Red;
        professor.SubscribeToNotification(s1);
        professor.SubscribeToNotification(s2);
        professor.SubscribeToNotification(s3);
        Console.ResetColor();

        // Notify students
        Console.ForegroundColor = ConsoleColor.Green;
        professor.NotifyStudent();
        Console.ResetColor();

        // Unsubscribe a student
        Console.ForegroundColor = ConsoleColor.Yellow;
        professor.UnsubscribeFromNotification(s1);
        Console.WriteLine($"Unsubscribed {s1.Name} from notifications.");
        professor.UnsubscribeFromNotification(s3);
        Console.WriteLine($"Unsubscribed {s3.Name} from notifications.");
        Console.ResetColor();

        // Notify students again
        Console.ForegroundColor = ConsoleColor.Blue;
        professor.NotifyStudent();
        Console.ResetColor();
    }
}
