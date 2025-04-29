

int number = 90;
object obj = number;
Console.WriteLine(obj);

void PrintObj(object obj)
{
    Console.WriteLine(obj);
}
PrintObj(number);
PrintObj(true);
PrintObj(2.4);