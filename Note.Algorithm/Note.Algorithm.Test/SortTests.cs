using Microsoft.VisualStudio.TestTools.UnitTesting;
using Note.Algorithm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Algorithm.Tests
{
    [TestClass()]
    public class SortTests
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

        [TestMethod()]
        public void moveZerosTest()
        {
            int[] solution = new int[] { 5, 7, 6, 3, 0, 0 };
            // # leet Code 283.Move Zeros
            // # Concept - 
            // [0 5 0 7 6 3] ==> [5 7 6 3 0 0]
            // case : Hold on to 0 and swap to the right and move one space at a time
            // O (N * number of 0) == Bubble Swap
            //
            // At the heart of the Array issue:
            // 1. Use two index pointers.
            // 2. You don't have to swap. Just Copy it. (Overtise the rest to 0)
            int[] values = new int[] { 0, 5, 0, 7, 6, 3 };
            Sort.moveZeros(values);
            for (int i = 0; i < values.Length; i++)
            {
                Assert.AreEqual(values[i], solution[i]);
            }
            
        }
    }
}