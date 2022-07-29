using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class keep_multiplying_found_values_by_two
    {
        public int FindFinalValue(int[] nums, int original)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }

            while (set.Contains(original))
            {
                original = original * 2;
            }

            return original;
        }
    }
}

