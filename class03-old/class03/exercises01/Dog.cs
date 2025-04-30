namespace exercises01
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Color { get; set; }
        public static void Bark()
        {
            Console.WriteLine("Bark Bark");
        }
        public static void Validate()
        {
            
        }
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
    }
}
