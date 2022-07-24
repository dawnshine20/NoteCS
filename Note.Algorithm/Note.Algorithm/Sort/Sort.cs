using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Note.Algorithm
{
    public static class Sort
    {
        public static void InsertionSort<T>(IList<T> list, Comparison<T> comparison) where T : IComparable
        {
            if (list == null)
                throw new ArgumentNullException("list");
            if (comparison == null)
                throw new ArgumentNullException("comparison");

            int count = list.Count;

            // Ascending - If the next value is large,
            // replace the current value with the next value.
            for (int j = 1; j < count; j++)
            {
                T key = list[j];

                int i = j - 1;

                // Return 1 if the next value is greater than the current value
                for (; i >= 0 && comparison(list[i], key) > 0; i--)
                {
                    list[i + 1] = list[i];
                }
                list[i + 1] = key;
            }
        }

        

        public static void moveZeros(int[] nums)
        {
            int wideIndex = 0;
            // idx will pointing not zero value then, copy value
            for (int idx = 0; idx < nums.Length; idx++)
            {
                if(nums[idx] != 0)
                {
                    // copy
                    nums[wideIndex] = nums[idx];
                    wideIndex++;
                }
            }
            // After scanning all indexes and
            // recognizing that there are no zeros
            for (; wideIndex < nums.Length; wideIndex++)
            {
                nums[wideIndex] = 0;
            }
        }


    }
}
