
using Events.Entities;

AlarmClock alarmClock = new AlarmClock();
Person person = new Person { Name = "Robert"};
Person person2 = new Person { Name = "Martin" };
Person person3 = new Person { Name = "Jill" };

alarmClock.OnAlarmSounded += person.WakeUp;
alarmClock.OnAlarmSounded += person2.WakeUp;
alarmClock.OnAlarmSounded += person3.WakeUp;
alarmClock.Start();

Thread.Sleep(5000);
if (person.HasWokenUp)
{
    Console.WriteLine($"{person.Name} is awake!");
    alarmClock.OnAlarmSounded -= person.WakeUp;
}
else
{
    Console.WriteLine($"{person.Name} is still asleep.");
}
alarmClock.Start();
