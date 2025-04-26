namespace homework_class02.Entities
{
    public class Manager : Employee
    {
        public string Department { get; set; }
        public Manager(string fullName, string position, double salary, string department) : base(fullName, position, salary)
        {
            Department = department;
        }
        public override void CalculateSalary()
        {
            Salary += Salary * 0.1; // 10% bonus for managers
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {FullName}, Position: {Position}, Salary: {Salary}, Department: {Department}");
        }
    }
    
}
