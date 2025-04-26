using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            Console.WriteLine($"Area of the circle: {Math.PI * Math.Pow(Radius, 2)}");
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"Calculating area... {Math.PI * Math.Pow(Radius, 2)}");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter of the circle: {2 * Math.PI * Radius}");
        }
    }
   
}
