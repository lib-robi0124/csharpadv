using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
       

        public override void CalculateArea()
        {
            Console.WriteLine($"CalculateArea of the triangle: {0.5 * Base * Height}");
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine($"CalculatePerimeter of the triangle: {Base + Math.Sqrt(Base * Base + Height * Height) * 2}");
        }

        public override void GetArea()
        {
            Console.WriteLine($"Area of the triangle: {0.5 * Base * Height}");
        }
    }
}
