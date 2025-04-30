namespace Polymorphism.Models
{
    public class Pet
    {
        public string Name { get; set; }
       
        public virtual void Eat()
        {
            Console.WriteLine("wau makes a sound.");
        }
    }
}
