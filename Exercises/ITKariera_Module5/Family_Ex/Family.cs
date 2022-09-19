using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_Ex
{
    public class Family
    {
        private List<Person> family;

        public Family()
        {
            family = new List<Person>();
        }

        public Person this[int i]
        {
            get { return family[i]; }
        }

        public void AddPerson(string[] args)
        {
            family.Add(new Person(args[1], uint.Parse(args[2])));
            family = family.OrderBy(e => e.Name).ToList();
        }

        public void RemovePerson(string[] args)
        {
            if (family.Any(e => e.Name == args[1]))
            {
                family.Remove(family.Where(e => e.Name == args[1]).First());
            }
        }

        public override string ToString()
        {
            string[] people = new string[family.Count];
            for (int i = 0; i < family.Count; i++)
            {
                people[i] = family[i].ToString();
            }
            return String.Join("\n", people);
        }
    }
}
