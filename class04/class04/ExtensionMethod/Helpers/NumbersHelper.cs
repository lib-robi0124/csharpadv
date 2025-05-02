namespace ExtensionMethod.Helpers
{
    public static class NumbersHelper
    {
        public static bool IsEven(this int number)
        {
            if(number < 0)
                throw new ArgumentException("the number should not be less than 0");
            return number % 2 == 0;
        }
    }
}
