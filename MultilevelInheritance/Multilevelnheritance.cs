namespace MultilevelInheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }
    public class Mammal : Animal
    {
        public void walk()
        {
            Console.WriteLine("The mammal is walking");
        }
    }
    public class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("The Dog is barking");
        }
    }
    internal class Multilevelnheritance
    {
        static void Main(string[] args)
        {
            Dog dog  = new Dog();
            dog.Eat();
            dog.walk();
            dog.Bark();
        }
    }
}
