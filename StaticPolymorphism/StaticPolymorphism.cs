namespace StaticPolymorphism
{
    public class TestData
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    internal class StaticPolymorphism
    {
        static void Main(string[] args)
        {
            TestData data = new TestData();
            Console.WriteLine(data.Add(1, 2));
            Console.WriteLine(data.Add(3, 4, 5));
        }
    }
}
