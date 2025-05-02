namespace ExtensionMethod.PiggybackingHelpers
{
     public static class PiggybackingNumbersHelpers
    {
        public static bool IsEven(this int number)
        {
            if (number < 0)
                throw new ArgumentException("the number should not be less than 0");
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            if (number < 0)
                throw new ArgumentException("the number should not be less than 0");
            return number % 2 != 0;
        }

        public static bool PiggybackingIsEven(this int number)
        {
         
                if (number == 0)
                throw new ArgumentException("the number should not be 0");
                return number % 2 == 0;
            
        }
    }
}
