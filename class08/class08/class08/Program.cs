
#region Folder Manipulation
using System.Collections.Generic;

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"my current directory is: {currentDirectory} ");

// We create the path to the future folder that we want to create
string relativePath = @"..\..\..\";
Console.WriteLine($" Relative path to the curren folder is: {relativePath} ");


string absolutePath = "D:\\csharpadv\\class08\\class08\\class08";
Console.WriteLine($"Absolute path to the current folder is: {absolutePath}");


// Find folder - check if folder exists
bool ifDemoFolderExists = Directory.Exists(relativePath + @"DemoFolder");
bool ifDemofFolderExistsString = Directory.Exists(absolutePath + @"DemoFolder");
Console.WriteLine($"Does DemoFolder exists: {ifDemoFolderExists}");
Console.WriteLine($"Does DemoFolder path exists {ifDemofFolderExistsString}");

//Create folder
string demoFolderPath = relativePath + @"DemoFolder";
Console.WriteLine($"Does DemoFolder exists before {Directory.Exists(demoFolderPath)}");

if (!Directory.Exists(demoFolderPath))
{
    // Create the folder
    Directory.CreateDirectory(demoFolderPath);
    Console.WriteLine("New directory was created!");
}
Console.WriteLine($"Doea DemoFolder exists after {Directory.Exists(demoFolderPath)}");

Console.WriteLine("Press any key to delte the folder");
Console.ReadLine();

//if(ifDemoFolderExists)
//{
//    Directory.Delete(demoFolderPath);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("DemoFolder was deleted");
//    Console.ResetColor();
//}
//Console.ReadLine();

#endregion

#region FileManipulation - File

//string relativePath = @"..\..\..\";
string folderPath = relativePath + @"DemoFolder\";
string filePath = folderPath + @"demot.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("A new folde has been created!");
}
else
{
    Console.WriteLine("Folder already exists!");
}

//File create
if (!File.Exists(folderPath + @"demot.txt"))
{
    File.Create(folderPath + @"demot.txt").Close();
    Console.WriteLine("A file was created!");
}

//File delete
//if (File.Exists(folderPath + @"demot.txt"))
//{
//    File.Delete(folderPath + @"demot.txt");
//    Console.WriteLine("A file was deleted!");
//}

//write in file
if (File.Exists(folderPath + @"demot.txt"))
{
    File.WriteAllText(filePath, "Hello there! We are learning to write in txt file");
    Console.WriteLine("Succes write in");
}

//read from file
if (File.Exists(filePath))
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine("This content comes from a file");
    Console.WriteLine(content);
}


#endregion


