using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Ex
{
    public class Person
    {
        private string name;
        private uint age;

        public Person(string name, uint age)
        {
            this.name = name;
            this.age = age;
        }
        ~Person()
        {
            Console.WriteLine("Removed!");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return String.Format("My name is {0} and I'm {1} years old!", name, age);
        }
    }
}
