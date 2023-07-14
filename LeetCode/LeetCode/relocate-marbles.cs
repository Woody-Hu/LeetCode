using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class relocate_marbles
	{
        public IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }

            for (int i = 0; i < moveFrom.Length; i++)
            {
                set.Remove(moveFrom[i]);
                set.Add(moveTo[i]);
            }

            var res = set.ToList();
            res.Sort();
            return res;
        }
    }
}

