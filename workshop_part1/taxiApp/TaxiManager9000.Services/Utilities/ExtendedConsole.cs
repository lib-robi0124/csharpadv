using System.Threading.Channels;

namespace TaxiManager9000.Services.Utilities
{
    public static class ExtendedConsole
    {
        public static void WriteLine(string value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void Write(string value, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine();
        }
        public static string GetInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public static void Separator() => Console.WriteLine("-----------");
        public static void NoItemsMessage<T>() => Console.WriteLine($"No {typeof(T).Name}s available");
    }
}
