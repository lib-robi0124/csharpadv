using class02.Interfaces;

namespace class02.Enttities
{
    public class Developer : Human, IDeveloper
    {
       
        public Developer(string fullname, int age, long phonenumber, List<string> programminglanguages, int yearsofexperience) : base(fullname, age, phonenumber)
        {
            ProgrammingLanguages = programminglanguages;
            YearsOfExperience = yearsofexperience;
        }
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int YearsOfExperience { get; set; }

        public void Code()
        {
            Console.WriteLine("Tak tak tak tak");
            Console.WriteLine("*Opens Stack Overflow....Copy");
            Console.WriteLine("Paste.....Tak tak tak tak");
        }

        public void Debug()
        {
            Console.WriteLine("Dev debug");
        }

        public void DrinkCoffee()
        {
            Console.WriteLine("drink espresso");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsOfExperience} years in experience!";
        }
    }
}
