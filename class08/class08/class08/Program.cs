
#region Folder Manipulation
using System.Collections.Generic;

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);


string relativePath = @"..\..\..\";
Console.WriteLine(relativePath);

string absolutePath = "D:\\csharpadv\\class08\\class08\\class08";
Console.WriteLine(absolutePath);


// Find folder
bool ifDemoFolderExists = Directory.Exists(relativePath + @"DemoFolder");
bool ifDemofFolderExistsString = Directory.Exists(absolutePath + @"DemoFolder");
Console.WriteLine($"Does DemoFolder exists: {ifDemoFolderExists}");
Console.WriteLine($"Does DemoFolder path exists {ifDemofFolderExistsString}");

//Create folder
string demoFolderPath = relativePath + @"DemoFolder";
Console.WriteLine($"Doea DemoFolder exists before {Directory.Exists(demoFolderPath)}");

if(!Directory.Exists(demoFolderPath))
{
    Directory.CreateDirectory(demoFolderPath);
    Console.WriteLine("New directory was created!");
}
Console.WriteLine($"Doea DemoFolder exists after {Directory.Exists(demoFolderPath)}");

//Console.WriteLine("Press any key to delte the folder");
//Console.ReadLine();

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

string folderPath = relativePath + @"DemoFolder_1\";
string filePath = folderPath + @"demo.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("A new folde has been created!");
}

//File create
if (!File.Exists(folderPath + @"demo.txt"))
{
    File.Create(folderPath + @"demo.txt").Close();
    Console.WriteLine("A file was created!");
}

//File delete
//if (File.Exists(folderPath + @"demo.txt"))
//{
//    File.Delete(folderPath + @"demo.txt");
//    Console.WriteLine("A file was deleted!");
//}

//write in file
if (File.Exists(folderPath + @"demo.txt"))
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


