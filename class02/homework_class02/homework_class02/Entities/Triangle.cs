using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
        public void GetArea()
        {
            Console.WriteLine($"Area of the triangle: {0.5 * Base * Height}");
        }
    }
}
