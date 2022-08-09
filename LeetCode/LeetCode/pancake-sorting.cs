using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class pancake_sorting
    {
        public IList<int> PancakeSort(int[] arr)
        {
            var res = new List<int>();
            for (int n = arr.Length; n > 1; n--)
            {
                int index = 0;
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] >= arr[index])
                    {
                        index = i;
                    }
                }
                if (index == n - 1)
                {
                    continue;
                }
                Reverse(arr, index);
                Reverse(arr, n - 1);
                res.Add(index + 1);
                res.Add(n);
            }

            return res;
        }

        private void Reverse(int[] arr, int end)
        {
            for (int i = 0, j = end; i < j; i++, j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}
