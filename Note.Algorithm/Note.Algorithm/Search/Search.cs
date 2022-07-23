using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Algorithm
{
    public static class Search
    {
        public static int BinarySearch<T>(IList<T> list, T value, Comparison<T> comparison) where T : IComparable
        {
            int left = 0;
            int right = list.Count() - 1;

            while (left <= right)
            {
                int median = (left + right) / 2;
                T key = list.ElementAt(median);

                var result = comparison(value, key);
                
                if (result == 0)
                {
                    return median;
                }

                if (result < 0)
                {
                    right = median - 1;
                }
                else
                {
                    left = median + 1;
                }
            }

            return -1;
        }
    }
}
