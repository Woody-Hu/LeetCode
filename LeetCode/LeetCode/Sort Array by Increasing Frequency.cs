using System;
using System.Linq;

namespace LeetCode
{
    public class Sort_Array_by_Increasing_Frequency
    {
        public Sort_Array_by_Increasing_Frequency()
        {
        }

        public int[] FrequencySort(int[] nums)
        {
            var groups = nums.GroupBy(k => k).OrderBy(k => k.Count()).ThenByDescending(k => k.Key);
            var res = new int[nums.Length];
            var index = 0;
            foreach (var item in groups)
            {
                item.ToArray().CopyTo(res, index);
                index = index + item.Count();
            }

            return res;
        }
    }
}
