using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class minimum_impossible_or
	{
        public int MinImpossibleOR(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }

            var temp = 1;
            while (true)
            {
                if (!set.Contains(temp))
                {
                    return temp;
                }

                temp <<= 1;
            }
        }
    }
}

