namespace HierarchicalInheritance
{
    public class Father
    {
        public string FatherName()
        {
            return "Rajuprasad";
        }
    }

    public class  FirstChild : Father 
    {
        public string FirstChildName()
        {
            return "Munna";
        }
    }
    public class SecondChild : Father
    {
        public string SecondChildName()
        {
            return "Chintu";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstChild first = new FirstChild();
            Console.WriteLine("My name is {0}, my father name is {1}", first.FirstChildName(), first.FatherName());
        }
    }
}
