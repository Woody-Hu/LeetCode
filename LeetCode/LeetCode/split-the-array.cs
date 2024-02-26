using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class split_the_array
	{
        public bool IsPossibleToSplit(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
                if (dic[item] > 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

