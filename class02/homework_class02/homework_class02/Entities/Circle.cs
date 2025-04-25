using homework_class02.Interfaces;

namespace homework_class02.Entities
{
    public class Circle : Shape, IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void GetArea()
        {
            Console.WriteLine($"Area of the circle: {Math.PI * Math.Pow(Radius, 2)}");
        }

        public override int CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override int CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
    //{
    //    public double Radius { get; set; }
    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }
    //    public void GetArea()
    //    {
    //        Console.WriteLine($"Area of the circle: {Math.PI * Math.Pow(Radius, 2)}");
    //    }
    //}
}
