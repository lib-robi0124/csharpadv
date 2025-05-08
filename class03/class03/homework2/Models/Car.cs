namespace homework2.Models
{
    public class Car : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Im a car and i drive on 4 wheels :)");
        }
        public override void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}
