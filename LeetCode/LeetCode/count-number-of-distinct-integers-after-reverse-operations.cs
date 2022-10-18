using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class count_number_of_distinct_integers_after_reverse_operations
    {
        public int CountDistinctIntegers(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
                set.Add(Revert(item));
            }

            return set.Count;
        }

        private int Revert(int input)
        {
            var res = 0;
            while (input > 0)
            {
                res = res * 10 + input % 10;
                input = input / 10;
            }

            return res;
        }
    }
}
