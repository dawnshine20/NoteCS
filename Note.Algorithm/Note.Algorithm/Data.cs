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

        /// <summary>
        /// Return 1 if value is large based on key, 
        /// return -1 if less, 
        /// return 0 if equal
        /// </summary>
        /// <param name="x"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Compare(Person value, Person key)
        {
            int result = 1;
            if (value != null && value is Person &&
                key != null && key is Person)
            {
                Person personX = (Person)value;
                Person personY = (Person)key;
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
