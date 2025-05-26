
string filePath = @"../../../Files";
string fileName = "names.txt";

void WriteInFile(string filePath, string fileName, string content)
{
    if (!Directory.Exists(filePath))
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
    string fullPath = Path.Combine(filePath, fileName);
    if (File.Exists(fullPath))
    {
        using (StreamReader sr = new StreamReader(fullPath))
        {
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }
    }
    else
    {
        Console.WriteLine($"File {fileName} not found.");
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Please enter some name:");
    string userInput = Console.ReadLine();
    
    WriteInFile(filePath, fileName, userInput);
}

// Read the full file
Console.WriteLine("\nAll names:");
ReadFromFile(filePath, fileName);


string filteredFileName = "namesStartingWith_A.txt";
void FilterNamesStartingWithA(string filePath, string fileName, string filteredFileName)
{
    List<string> namesStartingWithA = new List<string>();
    using (StreamReader sr = new StreamReader(Path.Combine(filePath, fileName)))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            if (line.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                namesStartingWithA.Add(line);
            }
        }
    }
    if (namesStartingWithA.Count > 0)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, filteredFileName)))
        {
            foreach (var name in namesStartingWithA)
            {
                sw.WriteLine(name);
            }
        }
    }
}
// Filter and write names starting with A
FilterNamesStartingWithA(filePath, fileName, filteredFileName);

// Try to read the filtered file if it was created
Console.WriteLine("\nNames starting with A:");
ReadFromFile(filePath, filteredFileName);