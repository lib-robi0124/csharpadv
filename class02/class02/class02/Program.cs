

#region Abstract class

//Human human = new Human(); not possible from abstract class
using class02.Enttities;

Developer dev = new Developer("Robert Ristovski", 31, 07777777,
    new List<string> { "JavaScript", "C#" }, 15);

Tester tester = new Tester("Bob Bobsky", 32, 07111111, 100);

Console.WriteLine("The Developer:");
Console.WriteLine(dev.GetInfo());
dev.Greet("Students");
dev.Code();
dev.Debug();


Console.WriteLine("---------------------------");
Console.WriteLine("The tester:");
Console.WriteLine(tester.GetInfo());
tester.Greet("Students");
tester.TestFeature("Demo example feature");
tester.DocumentBugs();
tester.WriteTestCases();

if (tester.FoundBug())
    {
    Console.WriteLine("The Tester found a bug!! fix it");
}

#endregion