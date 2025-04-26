namespace homework_class02.Entities
{
    public class Programmer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Programmer(string fullName, string position, double salary, string programmingLanguage) : base(fullName, position, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        public override void CalculateSalary()
        {
            Salary += Salary * 0.15; // 15% bonus for programmers
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {FullName}, Position: {Position}, Salary: {Salary}, Programming Language: {ProgrammingLanguage}");
        }
    }
   
}
