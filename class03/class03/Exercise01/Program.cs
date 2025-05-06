


using Exercise01;
using Exercise01.Models;

Dog dog1 = new Dog
{
    Id = 4,
    Name = "",
    Color = "Brown"
};
dog1.Bark();

Dog dog2 = new Dog
{
    Id = 5,
    Name = "Ada",
    Color = "White"
};
dog2.Bark();

if (Dog.Validate(dog1))
{
    Console.WriteLine("Dog 1 is valid.");
    DogShelter.Dogs.Add(dog1);
}
else
{
    Console.WriteLine("Dog 1 is invalid.");
}
if (Dog.Validate(dog2))
{
    Console.WriteLine("Dog 2 is valid.");
    DogShelter.Dogs.Add(dog2);
}
else
{
    Console.WriteLine("Dog 2 is invalid.");
}

DogShelter.PrintAllDogs();