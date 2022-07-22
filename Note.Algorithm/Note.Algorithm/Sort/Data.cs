using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Algorithm
{
    public class Person : IComparable
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name;
        public int Age;
        public int CompareTo(object obj)
        {
            int result = 1;
            if (obj != null && obj is Person)
            {
                Person person = (Person)obj;
                result = this.Age.CompareTo(person.Age);
            }
            return result;
        }

        public static int Compare(Person x, Person y)
        {
            int result = 1;
            if (x != null && x is Person &&
                y != null && y is Person)
            {
                Person personX = (Person)x;
                Person personY = (Person)y;
                result = personX.CompareTo(personY);
            }
            return result;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Name, this.Age);
        }
    }
}
