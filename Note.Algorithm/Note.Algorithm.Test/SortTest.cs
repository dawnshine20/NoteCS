
using Note.Algorithm;
using System.Diagnostics;

namespace Note.Algorithm.Test
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void UnStable()
        {
            List<Person> list = new List<Person>()
            {
                new Person("A", 200),
                new Person("B", 200),
                new Person("C", 200),
                new Person("D", 200),
                new Person("E", 200)
            };

            for (int i = 0; i < 30; i++)
            {
                list.Add(new Person("Z", i));
            }

            // General Function (Quick, Heap)
            list.Sort();

            Debug.WriteLine("Unstable List Sort:");
            foreach (Person p in list)
            {
                Debug.WriteLine(p);
            }
            Debug.WriteLine("stop");
        }

        [TestMethod]
        public void Stable()
        {
            List<Person> list = new List<Person>()
            {
                new Person("A", 200),
                new Person("B", 200),
                new Person("C", 200),
                new Person("D", 200),
                new Person("E", 200)
            };

            for (int i = 0; i < 30; i++)
            {
                list.Add(new Person("Z", i));
            }

            // My Function (Merge)
            Sort.InsertionSort<Person>(list, Person.Compare);

            Debug.WriteLine("Stable Insertion Sort:");
            foreach (Person p in list)
            {
                Debug.WriteLine(p);
            }
            Debug.WriteLine("stop");
        }
    }
}