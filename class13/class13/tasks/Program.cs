Console.WriteLine("App start...");

//single task example

Task myTask = new Task(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("this comes into console after 2s");
});
myTask.Start();

//single task with return type
Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("We can now get the number...");
    //return 10;
    throw new Exception("Something went wrong!");
});
Console.WriteLine("Task status: " + valueTask.Status);
valueTask.Start();
Console.WriteLine("Task status: " + valueTask.Status);

Thread.Sleep(3000);
Console.WriteLine("Task status: " + valueTask.Status);
if (valueTask.IsCompleted)
{
    Console.WriteLine("Task completed!");
}
else
{
    Console.WriteLine("Task still running on some thread!");
}

if (valueTask.IsCompletedSuccessfully)
{
    Console.WriteLine("My value task is completed succesfully!");
}
else
{
    Console.WriteLine("My value task is not completed succesfully!");
}

Task.Run(() =>
{
    Thread.Sleep(3000);
    Console.WriteLine("This is executed immediately");
});

Console.WriteLine(valueTask.Result);

Console.WriteLine("App end...");