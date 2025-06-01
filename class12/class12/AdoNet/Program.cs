using AdoNet.Models;
using AdoNet.Services;

void PrintInColor(string text, ConsoleColor color = ConsoleColor.White)
{
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
}

void PrintStudents(List<Student> students)
{
    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
}
string connectionString = "Server=.\\SQLEXPRESS;Database=SEDC_DEMO_SHARP;Trusted_Connection=True;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";

StudentService studentService = new StudentService(connectionString);

PrintInColor("\n===All Students===", ConsoleColor.Cyan);
var allStudents = studentService.GetAllStudents();
PrintStudents(allStudents);

PrintInColor("\n===Insert new student===", ConsoleColor.Cyan);

string firstName = Console.ReadLine();
Student newStudent = new Student
{
    FirstName = firstName,
    LastName = Console.ReadLine(),
    DateOfBirth = new DateTime(1972, 8, 24),
    EnrolledDate = DateTime.Now,
    Gender = 'M',
    NationalIdNumber = 1234345234,
    StudentCardNumber = "SC-123-123"

};
studentService.InsertStudent(newStudent);

PrintInColor("\n====get student by id===", ConsoleColor.Cyan);

if (int.TryParse(Console.ReadLine(), out int studentId))
{
    Student student = studentService.GetStudentById(studentId);
    if (student != null)
    {
        PrintInColor("Student found", ConsoleColor.Green);
        PrintInColor(student.ToString(), ConsoleColor.Magenta);
    }
    else
    {
        PrintInColor("student not found", ConsoleColor.Red);
    }
}
Console.ReadLine();
