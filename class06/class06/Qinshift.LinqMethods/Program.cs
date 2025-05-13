using Qinshift.Class06.LinqMethods.Entities;
using Qinshift.Class06.LinqMethods.Helpers;
using Qinshift.Class06.LinqMethods;


//Where

// SQL like sintax

Console.WriteLine("==WHERE==");
IEnumerable<Student> findBobSql = from std in Database.Students where std.FirstName == "Bob" select std;


//Lambda
IEnumerable<Student> findBobLamda = Database.Students.Where(x => x.FirstName == "Bob");

findBobSql.ToList().PrintEntities();
findBobLamda.ToList().PrintEntities();


//SELECT
Console.WriteLine("==SELECT==");
//SQL like

List<string> firstNameSql = (from std in Database.Students select std.FirstName).ToList();

firstNameSql.PrintSimple();
List<string> studentFullNamesSql = (from std in Database.Students select $"{std.FirstName} {std.LastName}").ToList();
studentFullNamesSql.PrintSimple();

//Lambda

List<string> firsttNamesLinq = Database.Students.Select(x => x.FirstName).ToList();
firsttNamesLinq.PrintSimple();
//List<string> studentDullNameLinq = Database.Students.Select(x => $"{std.FirstName} {std.LastName}").ToList();

//all partTime students on programming

List<Student> progrStudentsSql = (from std in Database.Students where std.IsPartTime && std.Subjects is not null
                                  where (from sub in std.Subjects where sub.Type == Academy.Programming
                                         select sub).ToList().Count != 0 select std).ToList();

progrStudentsSql.PrintEntities();


//Linq
List<Student> paartTimeProgrammingStudentsLinq = Database.Students.Where((x) => x.IsPartTime && x.Subjects is not null)
                                                .Where(x => x.Subjects.Where(y => y.Type == Academy.Programming).ToList().Count != 0).ToList();


paartTimeProgrammingStudentsLinq.PrintEntities();

//First / Single / Last / OrDefault

Console.WriteLine("==FIRST / Single / Last / OrDefault ==");


List<string> emptyListOfStrings = new();
List<Student> emptyListOfStudent = new();

Console.WriteLine(Database.Students.First().Info());
Console.WriteLine(Database.Students.FirstOrDefault(x => x.FirstName.StartsWith('T')).Info());

Console.WriteLine(emptyListOfStudent.FirstOrDefault());

//Console.WriteLine(Database.Students.Single(x => x.Age == 22).Info()); // error exception - not single
Console.WriteLine(Database.Students.SingleOrDefault(x => x.Id == 12)?.Info());


//Select many
Console.WriteLine("==SELECT Many ==");

//select list of all students parttime their subjects

var partTimeStudentsAllSubjects = Database.Students.Where(x => x.IsPartTime && x.Subjects is not null)
                                    .SelectMany(x => x.Subjects).ToList(); //SelectMany is creating FROM List<List<any>> TO List<Many>

partTimeStudentsAllSubjects.PrintEntities();

var partTimeStudentsAllSubjectsDisting = partTimeStudentsAllSubjects.Distinct().ToList();

Console.WriteLine("==after dinsting ==");

partTimeStudentsAllSubjectsDisting.PrintEntities();





