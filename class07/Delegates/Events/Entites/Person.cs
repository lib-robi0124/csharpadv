namespace Events.Entites
{
    public class Person
    {
        public string Name { get; set; }
        public bool HasWokeUp { get; set; } = false;
        public void WakeUp()
        {
            Console.WriteLine($"{Name} waaaaaaake uup!!!");
            HasWokeUp = true;
        }
    }
}
