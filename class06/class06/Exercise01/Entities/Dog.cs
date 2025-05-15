using Exercise01.Enum;

namespace Exercise01.Entities
{
    public class Dog : BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, string color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }

        public override string Info()
        {
            return $"{Id}) {Name} with the color {Color}  is {Race} race!";
        }
        public string Info2(Dog item)
        {
            return $"{item.Id}) {item.Name} with the color {item.Color}" +
                $" is {item.Age} years old is {item.Race} race!";
        }
    }
}
