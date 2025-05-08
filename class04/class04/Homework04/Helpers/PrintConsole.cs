namespace Homework04.Helpers
{
    public static class PrintConsole
    {
        public static void Print<T>(List<T> items)
        {
           foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintCollection<T>(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
