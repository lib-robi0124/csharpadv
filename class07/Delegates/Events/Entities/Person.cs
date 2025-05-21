namespace Events.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public bool HasWokenUp { get; set; }
       
        public void WakeUp()
        {
            Console.WriteLine($"{Name} has woken up!");
            HasWokenUp = true;
        }
    }
}
