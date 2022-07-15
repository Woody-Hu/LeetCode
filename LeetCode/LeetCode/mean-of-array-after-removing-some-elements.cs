using System;
using System.Linq;

namespace LeetCode
{
    public class mean_of_array_after_removing_some_elements
    {
        public double TrimMean(int[] arr)
        {
            Array.Sort(arr);
            var l = arr.Length;
            var skip = l / 20;
            var count = (int)(arr.Count() * 0.9d);
            var use = arr.Skip(skip).Take(count);
            var useCount = use.Count();
            var sum = 0.0d;
            foreach (var item in use)
            {
                sum += item;
            }

            return sum / useCount;

        }
    }
}
