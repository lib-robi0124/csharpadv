
namespace homework2.Models
{
    public class Vehicle
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I am a vehicle.");
        }

        public virtual void Drive() // Marked as virtual to allow overriding  
        {
            Console.WriteLine("The vehicle is driving.");
        }

        public virtual void Fly()
        {
            Console.WriteLine("The vehicle is flying.");
        }

        public virtual void Sail()
        {
            Console.WriteLine("The vehicle is sailing.");
        }

        public virtual void Wheelie()
        {
            Console.WriteLine("The vehicle is doing a wheelie.");
        }
    }
}
