using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Sum_of_Unique_Elements
    {
        public int SumOfUnique(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                dict[item] = dict.GetValueOrDefault(item) + 1;
            }

            var res = 0;
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    res += item.Key;
                }
            }

            return res;
        }
    }
}
