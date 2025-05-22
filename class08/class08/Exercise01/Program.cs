
string appPath = @"..\..\..\";
string folderPath = appPath + @"Exercise\";
string filePath = folderPath + @"calculations.txt";
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
    using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName)
    {
        sw.WriteLine(fileName);
    }
}