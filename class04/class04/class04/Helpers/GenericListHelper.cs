namespace class04.Helpers
{
    public class GenericListHelper<T>
    {
        public static void GoThroughItems(List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetInfoForItems(List<T> items)
        {
            T first = items.First();
            Console.WriteLine($"this list has {items.Count} items and is of type {first.GetType()}");
        }
    }
}
