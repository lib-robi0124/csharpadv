using Exercise01.Entities;
using Exercise01.Helpers;
using Exercise01;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER");
List<Person> firstNamesSql = (from p in DataBase.Persons
                              where p.FirstName.StartsWith('R')
                              orderby p.Age descending
                              select p).ToList();

List<Person> firstNamesLinq = DataBase.Persons
                            .Where(p => p.FirstName.StartsWith('R'))
                            .OrderByDescending(p => p.Age)
                            .ToList();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql");
firstNamesSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq");
firstNamesLinq.PrintEntities();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");
List<Dog> brownDogsSql = (from d in DataBase.Dogs
                          where d.Color == "Brown" && d.Age > 3
                          orderby d.Age ascending
                          select d).ToList();
List<Dog> brownDogsLinq = DataBase.Dogs
                        .Where(d => d.Color == "Brown" && d.Age > 3)
                        .OrderBy(d => d.Age)
                        .ToList();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql");
brownDogsSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq");
brownDogsLinq.PrintEntities();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
List<Person> moreThanTwoDogsSql = (from p in DataBase.Persons
                                   where p.Dogs.Count > 2
                                   orderby p.FirstName descending
                                   select p).ToList();
List<Person> moreThanTwoDogsLinq = DataBase.Persons
                                .Where(p => p.Dogs.Count > 2)
                                .OrderByDescending(p => p.FirstName)
                                .ToList();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql");
moreThanTwoDogsSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq");
moreThanTwoDogsLinq.PrintEntities();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Find and print all Freddy`s dogs names older than 1 year");
List<Dog> freddyDogsSql = (from d in DataBase.Dogs
                           where d.Age > 1 &&
                                 DataBase.Persons.Any(p => p.FirstName == "Freddy" && p.Dogs.Contains(d))
                           select d).ToList();
List<Dog> freddyDogsLinq = DataBase.Dogs
                                .Where(d => d.Age > 1 &&
                                 DataBase.Persons.Any(p => p.FirstName == "Freddy" && p.Dogs.Contains(d)))
                                .ToList();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql");
freddyDogsSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq");
freddyDogsLinq.PrintEntities();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Find and print Nathen`s first dog");
List<Dog> nathenFirstDogSql = (from d in DataBase.Dogs
                               where DataBase.Persons.Any(p => p.FirstName == "Nathen" && p.Dogs[0] == d)
                               select d).ToList();
List<Dog> nathenFirstDogLinq = DataBase.Dogs
                                .Where(d => DataBase.Persons.Any(p => p.FirstName == "Nathen" && p.Dogs[0] == d))
                                .ToList();
Dog firstNathenDogLinq = DataBase.Persons
                                .Single(p => p.FirstName == "Nathen").Dogs.First();
                                
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql");
nathenFirstDogSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq");
nathenFirstDogLinq.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("print from linq Nathen-simple");
Console.WriteLine(firstNathenDogLinq.Info2(firstNathenDogLinq));
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER");
List<string> dogOwners = new() { "Cristofer", "Freddy", "Erin", "Amelia" };
List<string> dogsNamesLinq = DataBase.Persons
    .Where(p => dogOwners.Contains(p.FirstName))
    .SelectMany(p => p.Dogs)
    .Where(d => d.Color == "White")
    .OrderBy(d => d.Name)
    .Select(d => d.Name)
    .ToList();
List<string> dogsNamesSql = (from p in DataBase.Persons
                             where dogOwners.Contains(p.FirstName)
                             from d in p.Dogs
                             where d.Color == "White"
                             orderby d.Name ascending
                             select d.Name).ToList();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql");
dogsNamesSql.PrintSimple();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq");
dogsNamesLinq.PrintSimple();
Console.ResetColor();


