using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Kth_Missing_Positive_Number
    {
        public int FindKthPositive(int[] arr, int k)
        {
            var min = arr[0];
            if (k < min)
            {
                return k;
            }

            int count = 0, i = 1, missing = 0, j = 0;
            if (min > 0)
            {
                count = min - 1;
                missing = min - 1;
                i = min;
            }

            while (count < k && j < arr.Length)
            {
                if (arr[j] != i)
                {
                    count++;
                    missing = i;
                    i++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            int max = arr[arr.Length - 1];
            if (count < k)
            {
                return max + (k - count);
            }

            return missing;
        }
    }
}
