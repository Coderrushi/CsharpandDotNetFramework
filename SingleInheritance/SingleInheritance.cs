namespace SingleInheritance
{
    public class BaseClass
    {
        public void display1()
        {
            Console.WriteLine("display1() method from BaseClass");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void display2()
        {
            display1();
            Console.WriteLine("display2() method from DerivedClass");
        }
    }
    internal class SingleInheritance
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.display2();
        }
    }
}
