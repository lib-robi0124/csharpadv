List<string> names = new() { "Ada", "Sara", "Toska", "Robert" };
int Sum(int x, int y)
{
    return x + y;
}

int Diff(int x, int y)
{
    return x - y;
}

int Multiply(int x, int y)
{
    return x * y;
}

#region Func

Func<int, int, int> sumOftwo = (x, y) => x + y;
Func<int, int, int> diffOfTwo = (x, y) => x - y;
Func<int, int, int> mulOfTwo = (x, y) => x * y;

Func<int, int, bool> checkIfLarger = (x, y) =>
{
    if (x > y)
        return true;
    return false;
};

Console.WriteLine($"The sum of 5 and 10 is {sumOftwo(5, 10)}");
Console.WriteLine($"The difference of 10 and 4 is {sumOftwo(10, 4)}");
Console.WriteLine($"The product of 123 and 10 is {sumOftwo(123, 10)}");
if (checkIfLarger(10, 20))
{
    Console.WriteLine("10 is larger");
}
else
{
    Console.WriteLine("20 is larger");
}



Func<List<string>, bool> isListEmpty = (list) => list.Count == 0;

Console.WriteLine($"Is The list of names is empty {isListEmpty(names)}");



#endregion

Console.WriteLine("====== ACTION ======");
#region action

Action hello = () => Console.WriteLine("Hello there!!");

hello();


Action<string> printInRed = (text) =>
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ResetColor();
};
printInRed("This will be print in Red");

Action<string, ConsoleColor> printInColor = (text, color) =>
{
    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(text);
    Console.ResetColor();
};

#endregion

Console.WriteLine("==== H Order ===");
#region Higher Order func use

string foundToska = names.Find(x => x == "Toska");
Console.WriteLine($"{foundToska}");

Predicate<string> isRobert = x => x == "Robert";

string foundRobert = names.Find(isRobert);
Console.WriteLine(foundRobert);


#endregion

