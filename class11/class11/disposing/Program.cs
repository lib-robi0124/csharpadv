
using disposing;

const string AppPath = @"../../../Text";
const string FilePath = AppPath + @"\text.txt";

void CreateFolder(string path)
{
    if (!File.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }
}
CreateFolder(AppPath);
CreateFile(FilePath);

#region Manual Dispose Methods
void AppendTextInFile(string text, string path)
{
    StreamWriter streamWriter = new StreamWriter(path, true);
    streamWriter.WriteLine(text);
    streamWriter.Dispose();
}

void ReadTextInFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}
void ManualDisposeExample()
{
    string text1 = Console.ReadLine();
    AppendTextInFile(text1, FilePath);
    string text2 = Console.ReadLine();
    AppendTextInFile(text2, FilePath);
    string text3 = Console.ReadLine();
    AppendTextInFile(text3, FilePath);

    ReadTextInFile(FilePath);

}

//ManualDisposeExample();


#endregion

#region using block

void AppendTextInFileSafe(string text, string path)
{
   using StreamWriter streamWriter = new StreamWriter(path, true);
    streamWriter.WriteLine(text);
   
}

void ReadTextInFileSafe(string path)
{
   using(StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}
void UsingDisposeExample()
{
    Console.WriteLine("Enter part1:");
    string text1 = Console.ReadLine();
    AppendTextInFileSafe(text1, FilePath);
    Console.WriteLine("Enter part2");
    string text2 = Console.ReadLine();
    AppendTextInFileSafe(text2, FilePath);
    Console.WriteLine("Enter part3");
    string text3 = Console.ReadLine();
    AppendTextInFileSafe(text3, FilePath);

    ReadTextInFileSafe(FilePath);

}

//UsingDisposeExample();
#endregion


#region Dispose with our class
void AppendTextInFileOwn(string text, string path)
{
    using (OurWriter ourWriter = new OurWriter(path))
    {
        ourWriter.Write(text);
    }

}

void ReadTextInFileOwn(string path)
{
    using (StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }
}
void OurDisposeExample()
{
    Console.WriteLine("Enter part1:");
    string text1 = Console.ReadLine();
    AppendTextInFileOwn(text1, FilePath);
    Console.WriteLine("Enter part2");
    string text2 = Console.ReadLine();
    AppendTextInFileOwn(text2, FilePath);
    Console.WriteLine("Enter part3");
    string text3 = Console.ReadLine();
    AppendTextInFileOwn(text3, FilePath);

    ReadTextInFileOwn(FilePath);

}

OurDisposeExample();
#endregion
