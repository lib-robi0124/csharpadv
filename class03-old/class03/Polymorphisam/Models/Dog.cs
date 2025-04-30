namespace Polymorphisam.Models
{
    public class Dog : Pet
    {
        public bool IsGoodBoy { get; set; }
        public override void Eat()
        {
            Console.WriteLine($"Dog is");
        }
    }
}
