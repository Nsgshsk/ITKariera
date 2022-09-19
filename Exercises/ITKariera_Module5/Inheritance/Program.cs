using Inheritance;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList a = new RandomList();
            a.Add(true);
            a.Add("Game");
            a.Add(45);
            Console.WriteLine(a.RandomObject());

            //Animal dog = new Dog("Rex", 2);
            //Console.WriteLine(dog.Name);
            //Console.WriteLine(dog.Age);
            //dog.Eat();
            //dog.Bark();
        }
    }

    public class Animal
    {
        protected string name;
        protected int age;
        private int counter;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            counter = 5;
        }

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public void Eat()
        {
            Console.Write("Eating");
            for (; counter > 0; counter--)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            
        }

        public void Bark()
        {
            Console.WriteLine("Bark...");
        }
    }
    
    //public class Cat : Animal
    //{

    //}
}