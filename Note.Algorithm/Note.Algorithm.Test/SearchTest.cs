
using Note.Algorithm;
using System.Diagnostics;

namespace Note.Algorithm.Test
{
    [TestClass]
    public class SearchTest
    {
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

        [TestMethod()]
        public void FindPivotIndexTest()
        {
            // # leet Code 724.Find Pivot Index
            // # Concept - sliding (avilable when all arrays are positive)
            // 
            // At the heart of the Array issue:
            
            int[] values = new int[] { 0, 5, 0, 7, 6, 3 };
            int result = Search.FindPivotIndex(values);
            
        }
    }
}