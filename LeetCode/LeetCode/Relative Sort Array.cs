using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Relative_Sort_Array
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var k = 0;
            var array = new int[1001];
            var res = new int[arr1.Length];

            foreach (var oneValue in arr1)
            {
                array[oneValue]++;
            }

            foreach (var oneValue in arr2)
            {
                while (array[oneValue]-- > 0)
                {
                    res[k++] = oneValue;
                }
            }

            for (int i = 0; i < 1001; i++)
            {
                while (array[i]-- > 0)
                {
                    res[k++] = i;
                }
            }

            return res;
        }
    }
}
