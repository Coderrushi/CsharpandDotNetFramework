namespace HierarchicalInheritance1
{
    public class FatherClass
    {
        public string FatherName()
        {
            return "Rajuprasad";
        }
    }
    public class FirstChildClass : FatherClass 
    {
        public string FirstChildName()
        {
            return "Bunty";
        }
    }
    public class SecondChildClass : FatherClass 
    {
        public string SecondChildName()
        {
            return "Bubli";
        }
    }
    internal class HierarchicalInheritance1
    {
        static void Main(string[] args)
        {
            FirstChildClass first = new FirstChildClass();
            Console.WriteLine("My name is {0}, my father name is {1}", first.FirstChildName(), first.FatherName());
            SecondChildClass second = new SecondChildClass();
            Console.WriteLine("My name is {0}, my father name is {1}", second.SecondChildName(), second.FatherName());
        }
    }
}
