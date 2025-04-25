using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public void GetArea()
        {
            Console.WriteLine($"Area of the rectangle: {Length * Width}");
        }
    }
}
