using StaticClasses;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Models;

//Console.ForegroundColor = ConsoleColor.DarkCyan;
//Console.WriteLine("=== Welcome to Order Managment App ===");
//Console.ResetColor();

// Cannot create an instance from *static* class
//ConsoleHelper consoleHelper = new ConsoleHelper();
//consoleHelper.WriteInColor("");

bool isRunning = true;
while (isRunning)
{
    Console.Clear();
    ConsoleHelper.WriteInColor("=== Welcome to Order Managment App ===", ConsoleColor.DarkCyan);
    Console.WriteLine("\nPlease choose an option");
    Console.WriteLine("1) List all users");
    Console.WriteLine("2) Add new order to user");
    Console.WriteLine("3) Show order status messages");
    Console.WriteLine("4) Exit");

    bool isValid = int.TryParse(Console.ReadLine(), out int input);  
    switch (input)
    {
        case 1:
            ConsoleHelper.WriteInColor("\nList all users", ConsoleColor.Green);
            OrderTempDB.ListUsers();
            break;
        case 2:
            ConsoleHelper.WriteInColor("\nEnter user Id", ConsoleColor.Yellow);
            int userId = Convert.ToInt32(Console.ReadLine());

            ConsoleHelper.WriteInColor("\nEnter order Title", ConsoleColor.Yellow);
            string title = Console.ReadLine();

            ConsoleHelper.WriteInColor("\nEnter order Description", ConsoleColor.Yellow);
            string description = Console.ReadLine();

            Order newOrder = new Order(0, title, description );
            OrderTempDB.InsertOrder(userId, newOrder);
            break;
        case 3:
            ConsoleHelper.WriteInColor("\nShow order status messages", ConsoleColor.Cyan);
            foreach (Order order in OrderTempDB.Orders)
            {
                ConsoleHelper.WriteInColor($"{order.Title} - {order.Status}", ConsoleColor.White);
                TextHelper.GetOrderStatusMessage(order.Status);
            }
            break;
        case 4:
            isRunning = false;
            ConsoleHelper.WriteInColor("Exiting the app...", ConsoleColor.Red);
            break;
        default:
            ConsoleHelper.WriteInColor("Invalid input, please try again", ConsoleColor.Red);
            break;
    }
    Console.ReadLine();
}
