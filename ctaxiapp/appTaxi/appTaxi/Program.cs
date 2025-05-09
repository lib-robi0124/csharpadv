

using Domain.Enums;
using Services;

static void Main(string[] args)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("🚕 Welcome to Taxi Manager 9000 🚕\n");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (UserService.Login(username, password))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Login successful! Welcome {UserService.LoggedInUser.Role} user.");
            Console.ResetColor();
            MainMenu();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Login unsuccessful. Please try again.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
static void MainMenu()
{
    var role = UserService.LoggedInUser.Role;
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"Main Menu - Logged in as {role}");
        Console.WriteLine("1. Change Password");
        Console.WriteLine("2. Logout");

        if (role == UserRole.Administrator)
        {
            Console.WriteLine("3. Create User");
            Console.WriteLine("4. Terminate User");
        }

        Console.Write("Select an option: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                // TODO: Change Password
                break;
            case "2":
                UserService.LoggedInUser = null;
                return;
            case "3" when role == UserRole.Administrator:
                CreateUserMenu();
                break;
            case "4" when role == UserRole.Administrator:
                // TODO: Terminate User
                break;
            default:
                Console.WriteLine("Invalid option. Try again.");
                break;
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}

static void CreateUserMenu()
{
    Console.Clear();
    Console.WriteLine("Create a new user:");
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();
    Console.WriteLine("Role: 1) Administrator  2) Manager  3) Maintenance");
    string roleInput = Console.ReadLine();

    UserRole role = roleInput switch
    {
        "1" => UserRole.Administrator,
        "2" => UserRole.Manager,
        "3" => UserRole.Maintenance,
        _ => throw new Exception("Invalid role")
    };

    bool result = UserService.CreateUser(username, password, role);
    Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
    Console.WriteLine(result ? $"User created successfully!" : "User creation failed.");
    Console.ResetColor();
}

