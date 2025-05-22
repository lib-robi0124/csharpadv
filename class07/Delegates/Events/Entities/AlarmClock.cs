namespace Events.Entities
{
    public class AlarmClock
    {
        public delegate void AlarmSounded();
        public event AlarmSounded OnAlarmSounded;

        //new way of declaring events
        //public delegate void AlarmSoundedNew(object source, EventArgs args);
        //public EventHandler<AlarmSounded> OnAlarmRing;
        public void Start()
        {
            // Logic to sound the alarm
            Console.WriteLine("Alarm is sounding!");
            Thread.Sleep(3000);
            OnAlarmSounded?.Invoke();
        }
        

    }
}
