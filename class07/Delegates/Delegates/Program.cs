
class Program
{
    static void SayHello(string person)
    {
        Console.WriteLine($"Hello there dear, {person}");
    }

    static void SayGoodBye(string person)
    {
        Console.WriteLine($"Goodbye {person}, see you next time!");
    }

    static void PrintNumber(int number)
    {
        Console.WriteLine(number);
    }

    static void SayWhatever(string whatever, SayDelegate sayDel)
    {
        Console.WriteLine("Chatbot says:");
        sayDel(whatever);
    }

    static void MasterCalculator(int a, int b, NumberDelelgate numberdel)
    {
        Console.WriteLine($"Result is {numberdel(a, b)}");
    }

    public delegate void SayDelegate(string person);
    public delegate int NumberDelelgate(int a, int b);
    static void Main(string[] args)
    {
        #region Declare
        SayDelegate sayHelloDel = new SayDelegate(SayHello);
        SayDelegate sayGoodByeDel = new SayDelegate(SayGoodBye);
        SayDelegate sayWoowDel = new SayDelegate(x => Console.WriteLine($"Woooow {x}"));


        //SayDelegate printNumDel = new SayDelegate(PrintNumber);   ---> this will not work, because the signature of the PrintNumber method doesn't fit with the signature of the SayDelegate delegate

        sayHelloDel("Bob");
        sayGoodByeDel("Martin");
        sayWoowDel("Slave");
        #endregion

        #region Passing a Method
        Console.WriteLine("=== region passing===");
        SayWhatever("Bob", SayHello);
        SayWhatever("Jill", SayGoodBye);



        #endregion

        #region Making a higher order method

        MasterCalculator(123, 235, (a, b) => a + b);
        MasterCalculator(234, 345, (a, b) => a * b);
        MasterCalculator(478, 22, (a, b) => a - b);
        MasterCalculator(675, 25, (a, b) => a / b);


        #endregion
    }
}