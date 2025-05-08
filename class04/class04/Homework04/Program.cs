using Homework04.Helpers;

List<int> ints = new List<int>() { 1, 3, 5, 7 };
List<bool> bools = new List<bool>() { true, false, true, true };
List<string> strings = new List<string>() { "Hello", "World", "!" };
Console.WriteLine("method print");
PrintConsole.Print(ints);
PrintConsole.Print(bools);
PrintConsole.Print(strings);
List<int> ints2 = new List<int>() { 1, 3, 5, 7 };
List<bool> bools2 = new List<bool>() { true, false, true, true };
List<string> strings2 = new List<string>() { "Hello", "World", "!" };
Console.WriteLine("method print collection");
PrintConsole.PrintCollection(ints2);
PrintConsole.PrintCollection(bools2);
PrintConsole.PrintCollection(strings2);



