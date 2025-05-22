

string appPath = @"..\..\..\";
string folderPath = appPath + @"MyFolder\";
string filePath = folderPath + @"test.txt";


string combinePaths = Path.Combine(folderPath, "test.txt");
Console.WriteLine(combinePaths);

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("new directory was created");
}


#region writing with StreamWriter

using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello Qinshift Academy");
    sw.WriteLine("This is new line added in the same file");
    Console.WriteLine("writing is completed");
}

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("this is new line without overwrite..");
    Console.WriteLine("t");
}

using (StreamReader sr = new StreamReader(filePath))
{
    string firstLine = sr.ReadLine();
    string secondLine = sr.ReadLine();

    string fileContent = sr.ReadToEnd();

    Console.WriteLine($"first Line {firstLine}");
    Console.WriteLine($"second Line {secondLine}");
    Console.WriteLine($"Read all {fileContent}");

}

#endregion