using Polymorphisam.Models;

namespace Polymorphisam
{
    public class PetService
    {
        public void PrintPetInfo() { Console.WriteLine("Some info"); }
        public void PrintPetInfo(Cat cat) 
        { Console.WriteLine($@"This Cat is {(cat.IsLazy ? "Lazy" : "not Lazy")}"); }

        public void PrintPetInfo(Cat cat, string ownerName)
        {
            Console.WriteLine($"The owner {ownerName} has cat name {cat.Name}");
        }

        public void PrintPetInfo(string ownerName, Cat cat )
        {
            Console.WriteLine($"The owner {ownerName} has cat name {cat.Name}");
        }

    }
}
