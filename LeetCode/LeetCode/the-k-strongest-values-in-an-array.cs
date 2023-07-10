using System;
namespace LeetCode
{
	public class the_k_strongest_values_in_an_array
	{
        public int[] GetStrongest(int[] arr, int k)
        {
            var res = new int[k];
            Array.Sort(arr);
            var n = arr.Length;
            var m = arr[(n - 1) / 2];
            var left = 0;
            var right = n - 1;
            for (int i = 0; i < k; i++)
            {
                if (Compare(arr[left], arr[right], m) > 0)
                {
                    res[i] = arr[left++];
                }
                else
                {
                    res[i] = arr[right--];
                }
            }

            return res;
        }

        private int Compare(int value1, int value2, int m)
        {
            var diff1 = Math.Abs(value1 - m);
            var diff2 = Math.Abs(value2 - m);
            if (diff1 != diff2)
            {
                return diff1 - diff2;
            }

            return value1 - value2;
        }
    }
}

