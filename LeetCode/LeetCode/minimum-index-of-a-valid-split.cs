using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class minimum_index_of_a_valid_split
	{
        public int MinimumIndex(IList<int> nums)
        {
            var dic = new Dictionary<int, int>();
            var mode = 0;
            var total = 0;
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
                if (dic[item] > total)
                {
                    total = dic[item];
                    mode = item;
                }
            }

            var freq1 = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                var x = nums[i];
                freq1 += x == mode ? 1 : 0;
                if (freq1 * 2 > i + 1 && (total - freq1) * 2 > nums.Count - i - 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

