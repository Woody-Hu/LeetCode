using System;
using System.Linq;

namespace LeetCode
{
    public class find_the_distance_value_between_two_arrays
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            var res = 0;
            foreach (var item in arr1)
            {
                if (arr2.All(k => Math.Abs(item - k) > d))
                {
                    res++;
                }
            }

            return res;
        }
    }
}
