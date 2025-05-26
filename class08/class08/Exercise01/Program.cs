
string appPath = @"..\..\..\";
string folderPath = appPath + @"Exercise\";
string filePath = folderPath + @"calculations.txt";
string filepath = @"../../../Exercise/";
string fileName = "calculations.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("new directory was created");
}

if (!File.Exists(folderPath + @"calculations.txt"))
{
    File.Create(filePath + @"calculations.txt").Close();
    Console.WriteLine("A file was created!");
}

// create a method to calculate 2 numbers
static double CalculateRR(double num1, double num2)
{

    double result = num1 + num2;
    Console.WriteLine($"result is {result}");
    return result;
}

int Calculate(int num1, int num2)
{
    return num1 + num2;
}
string FormatResult(int  num1, int num2, int result)
{
    return $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} - {num1} + {num2} = {result}";
}

void WriteInFIle(string filePath, string fileName, string content)
{
    if(!Directory.Exists(filePath))
    {
        Directory.CreateDirectory(filePath);
    }
    using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), true))
    {
        sw.WriteLine(content);
    }
    
}
void ReadFromFile(string filePath, string fileName)
{
    if (File.Exists(Path.Combine(filePath, fileName)))
    {
        using (StreamReader sr = new StreamReader(Path.Combine(filePath, fileName)))
        {
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }
    }
    else
    {
        Console.WriteLine("File does not exist!");
    }
}
int ConvertToInt(string input)
{
    if (!int.TryParse(input, out int result))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
        return 0; // or throw an exception, or handle it as needed
    }
    return result;
}
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Enter first number:");
        string userInput1 = Console.ReadLine();
        int num1 = ConvertToInt(userInput1);
        Console.WriteLine("Enter second number:");
        string userInput2 = Console.ReadLine();
        int num2 = ConvertToInt(userInput2);
        
        WriteInFIle(folderPath, "calculations.txt", FormatResult(num1, num2, Calculate(num1, num2)));
    }
ReadFromFile(filePath, "calculations.txt");