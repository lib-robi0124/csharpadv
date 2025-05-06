using Exercise01.Models;

namespace Exercise01
{
    public class DogShelter
    {
        public static List<Dog> Dogs { get; set; } = new List<Dog>();

        static DogShelter() // Removed 'public' access modifier to fix CS0515
        {
            Dogs = new List<Dog>()
               {
                   new Dog { Id = 1, Name = "Buddy", Color = "Brown" },
                   new Dog { Id = 2, Name = "Max", Color = "Black" },
                   new Dog { Id = 3, Name = "Bella", Color = "White" }
               };
        }
        public static void PrintAllDogs()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"Id: {dog.Id}, Name: {dog.Name}, Color: {dog.Color}");
            }
        }
    }
}
