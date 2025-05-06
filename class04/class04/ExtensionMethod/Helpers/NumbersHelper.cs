using System.Runtime.CompilerServices;

namespace ExtensionMethod.Helpers
{
    public static class NumbersHelper
    {
        public static int IsEven(this int number)
        {
            if (number == 0) return 0;

            if (number % 2 == 0)
                Console.WriteLine($" number {number} is even");
        }

    }
}
