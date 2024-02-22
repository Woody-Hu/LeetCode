using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class two_out_of_three
	{
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums1)
            {
                dic.TryAdd(item, 1);
            }

            foreach (var item in nums2)
            {
                dic.TryAdd(item, 0);
                dic[item] |= 2;
            }

            foreach (var item in nums3)
            {
                dic.TryAdd(item, 0);
                dic[item] |= 4;
            }

            var res = new List<int>();
            foreach (var item in dic)
            {
                var key = item.Key;
                var val = item.Value;
                if ((val & (val - 1)) != 0)
                {
                    res.Add(key);
                }
            }

            return res;
        }
    }
}

