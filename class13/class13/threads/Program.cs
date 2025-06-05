void SendMessages()
{
    Console.WriteLine("getting ready...");
    Thread.Sleep(1000);
    Console.WriteLine("First message arrived!");
    Thread.Sleep(1000);
    Console.WriteLine("Second message arrived!");
    Thread.Sleep(1000);
    Console.WriteLine("Third message arrived!");
    Console.WriteLine("All messages are received!");
    Console.ReadLine();
}

void SendMessagesWithTheards()
{
    Console.WriteLine("Getting Ready..");
    Thread myTheard = new Thread(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First message arrived!");
    });
    myTheard.Start();

    new Thread(() => {
        Thread.Sleep(2000);
        Console.WriteLine("Second message arrived!");
    }).Start();

    new Thread(() => {
        Thread.Sleep(2000);
        Console.WriteLine("Third message arrived!");
    }).Start();
    Console.WriteLine("All messages are received!");
    Console.ReadLine();
}


//SendMessages();
SendMessagesWithTheards();
