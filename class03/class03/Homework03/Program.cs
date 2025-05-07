using Homework03.Models;
using Homework03;

Console.WriteLine("Search by: 1) Id, 2) Name, 3) Age");
string choice = Console.ReadLine();

List<User> results = new List<User>();

switch (choice)
{
    case "1":
        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        results = UserTempDB.Search(id: id);
        break;
    case "2":
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        results = UserTempDB.Search(name: name);
        break;
    case "3":
        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        results = UserTempDB.Search(age: age);
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

if (results.Any())
{
    foreach (var user in results)
    {
        Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
    }
}
else
{
    Console.WriteLine("No users found.");
}

