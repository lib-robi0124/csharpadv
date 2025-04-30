

using Polymorphisam;
using Polymorphisam.Models;

Console.WriteLine("Hello, World!");

Pet randomPet = new Pet
{
    Name = "Mali",

};
randomPet.Eat();

Dog zuco = new Dog
{
    Name = "Zuco",
    IsGoodBoy = true,
};

zuco.Eat();

Cat mici = new Cat
{
    Name = "Mici",
    IsLazy = true,
};

mici.Eat();


PetService petService = new PetService();


petService.PrintPetInfo();
petService.PrintPetInfo("Bob", mici);
petService.PrintPetInfo(mici, "Bob");
petService.PrintPetInfo(mici);

