namespace Exercise01.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
        //A static method Validate() - Checks if dog has all 3 properties, if Id is not less than 0 and Name is 2 characters or longer
        public static bool Validate(Dog dog)
        {
            if (dog.Id < 0 || dog.Name.Length < 2 || string.IsNullOrEmpty(dog.Color))
            {
                return false;
            }
            return true;
        }
    }
}
