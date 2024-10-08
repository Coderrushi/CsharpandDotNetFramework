namespace DynamicPolymorphism
{
    internal class DynamicPolymorphism
    {
        public class Drawing
        {
            public virtual double Area()
            {
                return 0;
            }
        }
        public class Circle : Drawing
        {
            public Circle()
            {
                Radius = 5;
            }
            public double Radius { get; set; }
            public override double Area()
            {
                return 3.14 *Math.Pow(Radius, 2);
            }
        }
        public class Square : Drawing
        {
            public Square()
            {
                Length = 10;
            }
            public double Length { get; set; }
            public override double Area()
            {
                return Math.Pow(Length, 2);
            }
        }
        public class Rectangle : Drawing
        {
            public Rectangle()
            {
                Height = 12.2;
                Breadth = 10.2;
            }
            public double Height { get; set; }
            public double Breadth { get; set; }
            public override double Area()
            {
                return Height*Breadth;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());
            Square square = new Square();
            Console.WriteLine("Area of Square: " + square.Area());
            Circle circle = new Circle();
            Console.WriteLine("Area of Circle: "+circle.Area());
        }
    }
}
