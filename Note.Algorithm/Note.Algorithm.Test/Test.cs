
using Note.Algorithm;
using System.Diagnostics;

namespace Note.Algorithm.Test
{
    [TestClass]
    public class Test
    {
        // Link for algorithmic speed table:
        // https://gmlwjd9405.github.io/2018/05/10/algorithm-heap-sort.html
        [TestMethod]
        public void UnStableSorting()
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

            // General Function --->Speed (Quick(nlogn~n^2), Heap(nlogn))
            list.Sort();

            Debug.WriteLine("Unstable List Sort:");
            foreach (Person p in list)
            {
                Debug.WriteLine(p);
            }

            Debug.WriteLine(String.Empty);
        }

        [TestMethod]
        public void StableSorting()
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

            // My Function --->Speed (Merge(nlogn), Insert(n~n^2), bubble(n^2)) 
            Sort.InsertionSort<Person>(list, Person.Compare);

            Debug.WriteLine("Stable Insertion Sort:");
            foreach (Person p in list)
            {
                Debug.WriteLine(p);
            }
            Debug.WriteLine(String.Empty);
        }


        [TestMethod]
        public void BinarySearching()
        {
            const int solution = 20;
            List<Person> list = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                list.Add(new Person("Z", i));
            }
            list.Add(new Person("Z", solution));
            for (int i = 21; i < 30; i++)
            {
                list.Add(new Person("Z", i));
            }

            // My Function ---> look for people of the same age
            int answer = Search.BinarySearch<Person>(list, new Person("HB", solution), Person.Compare);

            Debug.WriteLine(String.Join(',',list));
            Assert.IsTrue(answer == solution);
            
            Debug.WriteLine(String.Empty);
        }
    }
}