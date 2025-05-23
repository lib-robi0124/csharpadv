class Program
{
    // Restricted users
    static readonly List<string> RestrictedUsers = new List<string> { "Bob", "Jill", "Alice" };

    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string username = Console.ReadLine();

        if(string.IsNullOrEmpty(username))
        {
            Console.WriteLine("Username cannot be empty.");
            return;
        }
        else if (RestrictedUsers.Contains(username, StringComparer.OrdinalIgnoreCase))
        {
            OnRestrictedUserDetected(username);
        }
        else
        {
            Console.WriteLine($"Welcome {username}.");
        }
    }

    static void OnRestrictedUserDetected(string username)
    {
        Console.WriteLine($"{username} Users Found. Sending Email to Administration.");
        SendEmailToAdministration();
        StartWarningAlarm();
        Console.WriteLine("Loging out.");
    }

    static void SendEmailToAdministration()
    {
        // Simulate sending email
        Console.WriteLine("Email Sent.");
    }

    static void StartWarningAlarm()
    {
        // Simulate alarm
        Console.WriteLine("Warning Alarm Started.");
    }
}
