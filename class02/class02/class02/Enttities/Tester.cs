using class02.Interfaces;

namespace class02.Enttities
{
    public class Tester : Human, ITester
    {
        public Tester(string fullname, int age, long phonenumber, int bugsfound) : base(fullname, age, phonenumber)
        {
            BugsFound = bugsfound;
        }

        public int BugsFound { get; set; }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested....");
            Console.WriteLine("Testing completed!");
        }
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {BugsFound} bugs found so far!";
        }

        public void DocumentBugs()
        {
            Console.WriteLine($"The Tester make docs {BugsFound}");
        }

        public void WriteTestCases()
        {
            Console.WriteLine("The Tester write cases..");
        }

        public bool FoundBug()
        {
            return BugsFound > 0;
        }
    }
}
