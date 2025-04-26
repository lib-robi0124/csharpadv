namespace homework_class02.Entities
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public Employee(string fullName, string position, double salary)
        {
            FullName = fullName;
            Position = position;
            Salary = salary;
        }
        public abstract void CalculateSalary();
        public abstract void DisplayInfo();

    }
}
