using HomeworkCars.Entities;
using HomeworkCars.Helpers;
using HomeworkCars;
using System.Reflection;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Filter all cars that have origin from Europe and print them in console");
List<Car> carsFromEuropeSql = (from c in DataBase.Cars
                               where c.Origin == "Europe"
                               select c).ToList();
List<Car> carsFromEuropeLinq = DataBase.Cars
                                .Where(c => c.Origin == "Europe")
                                .ToList();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql carsFromEuropeSql");
carsFromEuropeSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq carsFromEuropeLinq");
carsFromEuropeLinq.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" Filter all cars that have more that 6 Cylinders not including 6 " +
                "after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. " +
                "Join them in one result and print them in console.");
List<Car> carsWithMoreThanSixCylindersSql = (from c in DataBase.Cars
                                             where c.Cylinders > 6 && c.Cylinders != 6
                                             select c).ToList();
List<Car> carsWithMoreExactFourCylindersSql = (from c in DataBase.Cars
                                               where c.Cylinders == 4 && c.HorsePower > 110.0
                                               select c).ToList();
List<Car> carsWithMoreThanSixCylindersLinq = DataBase.Cars
                                                .Where(c => c.Cylinders > 6 && c.Cylinders != 6)
                                                .ToList();
List<Car> carsWithMoreExactFourCylindersLinq = DataBase.Cars
                                                .Where(c => c.Cylinders == 4 && c.HorsePower > 110.0)
                                                .ToList();
List<Car> carsWithMoreThanSixCylindersAndExactFourCylindersSql = carsWithMoreThanSixCylindersSql
    .Union(carsWithMoreExactFourCylindersSql)
    .ToList();
List<Car> carsWithMoreThanSixCylindersAndExactFourCylindersLinq = carsWithMoreThanSixCylindersLinq
    .Union(carsWithMoreExactFourCylindersLinq)
    .ToList();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql carsWithMoreThanSixCylindersAndExactFourCylindersSql");
carsWithMoreThanSixCylindersAndExactFourCylindersSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq carsWithMoreThanSixCylindersAndExactFourCylindersLinq");
carsWithMoreThanSixCylindersAndExactFourCylindersLinq.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Count all cars based on their Origin and print the result in console." +
                "(Example output US 10 models - new line- Eu 15 Models)");
List<string> carsCountByOriginSql = (from c in DataBase.Cars
                                     group c by c.Origin into g
                                     select $"{g.Key} {g.Count()} models").ToList();
List<string> carsCountByOriginLinq = DataBase.Cars
                                        .GroupBy(c => c.Origin)
                                        .Select(g => $"{g.Key} {g.Count()} models")
                                        .ToList();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql carsCountByOriginSql");
carsCountByOriginSql.PrintSimple();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq carsCountByOriginLinq");
carsCountByOriginLinq.PrintSimple();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Filter all cars that have more then 200 HorsePower and Find out how much is the lowest," +
                "highes and average Miles per galon");
List<Car> carsWithMoreThan200HorsePowerSql = (from c in DataBase.Cars
                                              where c.HorsePower > 200
                                              select c).ToList();
List<Car> carsWithMoreThan200HorsePowerLinq = DataBase.Cars
                                                .Where(c => c.HorsePower > 200)
                                                .ToList();
double lowestMilesPerGalonSql = carsWithMoreThan200HorsePowerSql.Min(c => c.MilesPerGalon);
double highestMilesPerGalonSql = carsWithMoreThan200HorsePowerSql.Max(c => c.MilesPerGalon);
double averageMilesPerGalonSql = carsWithMoreThan200HorsePowerSql.Average(c => c.MilesPerGalon);
double lowestMilesPerGalonLinq = carsWithMoreThan200HorsePowerLinq.Min(c => c.MilesPerGalon);
double highestMilesPerGalonLinq = carsWithMoreThan200HorsePowerLinq.Max(c => c.MilesPerGalon);
double averageMilesPerGalonLinq = carsWithMoreThan200HorsePowerLinq.Average(c => c.MilesPerGalon);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql lowHighAvgMilesPerGalonSql");
Console.WriteLine($"Lowest Miles per galon is {lowestMilesPerGalonSql}");
Console.WriteLine($"Highest Miles per galon is {highestMilesPerGalonSql}");
Console.WriteLine($"Average Miles per galon is {averageMilesPerGalonSql}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq lowHighAvgMilesPerGalonLinq");
Console.WriteLine($"Lowest Miles per galon is {lowestMilesPerGalonLinq}");
Console.WriteLine($"Highest Miles per galon is {highestMilesPerGalonLinq}");
Console.WriteLine($"Average Miles per galon is {averageMilesPerGalonLinq}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list");
List<Car> topThreeCarsByAccelerationTimeSql = (from c in DataBase.Cars
                                               orderby c.AccelerationTime ascending
                                               select c).Take(3).ToList();
List<Car> topThreeCarsByAccelerationTimeLinq = DataBase.Cars
                                                    .OrderBy(c => c.AccelerationTime)
                                                    .Take(3)
                                                    .ToList();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql topThreeCarsByAccelerationTimeSql");
topThreeCarsByAccelerationTimeSql.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq topThreeCarsByAccelerationTimeLinq");
topThreeCarsByAccelerationTimeLinq.PrintEntities();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Filter cars that have more than 6 cylinders. Calculate the total weight of these cars." +
                " Print the total weight.");
List<Car> carsWithMoreThanSixCylindersForWeightSql = (from c in DataBase.Cars
                                                      where c.Cylinders > 6
                                                      select c).ToList();
List<Car> carsWithMoreThanSixCylindersForWeightLinq = DataBase.Cars
                                                            .Where(c => c.Cylinders > 6)
                                                            .ToList();
double totalWeightSql = carsWithMoreThanSixCylindersForWeightSql.Sum(c => c.Weight);
double totalWeightLinq = carsWithMoreThanSixCylindersForWeightLinq.Sum(c => c.Weight);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql totalWeightSql");
Console.WriteLine($"Total weight of cars with more than 6 cylinders is {totalWeightSql}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq totalWeightLinq");
Console.WriteLine($"Total weight of cars with more than 6 cylinders is {totalWeightLinq}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Filter cars that have an even number of cylinders. Calculate the average MilesPerGalon for these cars." +
                " Print the average MilesPerGalon");
List<Car> carsWithEvenCylindersSql = (from c in DataBase.Cars
                                      where c.Cylinders % 2 == 0
                                      select c).ToList();
List<Car> carsWithEvenCylindersLinq = DataBase.Cars
                                            .Where(c => c.Cylinders % 2 == 0)
                                            .ToList();
double averageMilesPerGalonEvenCylindersSql = carsWithEvenCylindersSql.Average(c => c.MilesPerGalon);
double averageMilesPerGalonEvenCylindersLinq = carsWithEvenCylindersLinq.Average(c => c.MilesPerGalon);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("print from like Sql averageMilesPerGalonEvenCylindersSql");
Console.WriteLine($"Average Miles per galon of cars with even cylinders is {averageMilesPerGalonEvenCylindersSql}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("print from linq averageMilesPerGalonEvenCylindersLinq");
Console.WriteLine($"Average Miles per galon of cars with even cylinders is {averageMilesPerGalonEvenCylindersLinq}");
Console.ResetColor();
