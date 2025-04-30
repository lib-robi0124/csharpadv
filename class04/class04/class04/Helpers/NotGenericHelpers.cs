namespace class04.Helpers
{
    public class NotGenericHelpers
    {
        public void GoThroughStrings(List<string> strings)
        {
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }
        public void GetInfoForStrings(List<string> strings)
        {
            string first = strings.First();
            Console.WriteLine($"this list has {strings.Count} items and is type of {first.GetType().Name}");

        }

        public void GoThroughInts(List<int> ints)
        {
            foreach(int num in ints)
            { Console.WriteLine(num); }
        }
        public void GetInfoForInts(List<int> ints)
        {
            int first = ints.First();
            Console.WriteLine($"this list has {ints.Count} items and it is type of {ints.GetType().Name}");
        }
    }
}
