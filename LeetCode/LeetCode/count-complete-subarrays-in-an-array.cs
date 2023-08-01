using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_complete_subarrays_in_an_array
	{
        public int CountCompleteSubarrays(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var item in nums)
            {
                set.Add(item);
            }

            var m = set.Count;
            var dic = new Dictionary<int, int>();
            var res = 0;
            var left = 0;
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 0);
                }

                dic[item]++;
                while (dic.Count == m)
                {
                    var x = nums[left++];
                    dic[x]--;
                    if (dic[x] == 0)
                    {
                        dic.Remove(x);
                    }
                }

                res += left;
            }

            return res;
        }
    }
}

