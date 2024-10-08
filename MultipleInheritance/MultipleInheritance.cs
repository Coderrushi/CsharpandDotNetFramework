namespace MultipleInheritance
{
    interface IShape
    {
        public double GetArea();
    }
    interface IColor
    {
        public string GetColor();
    }
    public class Rectangle : IShape, IColor
    {
        private double length;
        private double breadth;
        private string color;
        public Rectangle(double length, double breadth, string color)
        {
            this.length = length;
            this.breadth = breadth;
            this.color = color;
        }
        public double GetArea()
        {
            double result = length * breadth;
            return result;
        }
        public string GetColor()
        {
            return color;
        }
    }
    internal class MultipleInheritance
    {
        
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(12.3, 13.4, "Red");
            Console.WriteLine("Area of the rectangle is "+ rectangle.GetArea());
            Console.Write("Color of rectangle is "+ rectangle.GetColor());
        }
    }
}
