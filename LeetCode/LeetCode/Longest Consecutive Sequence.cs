using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }

            var res = 0;
            foreach (var item in nums)
            {
                if (set.Remove(item))
                {
                    var num = item;
                    var sum = 1;
                    var value = item;
                    while (set.Remove(value-1))
                    {
                        value--;
                        sum++;
                    }

                    value = item;
                    while (set.Remove(value + 1))
                    {
                        value++;
                        sum++;
                    }

                    res = Math.Max(sum, res);
                }
            }

            return res;
        }
    }
}
