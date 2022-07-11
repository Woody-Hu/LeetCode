using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class number_of_pairs_of_strings_with_concatenation_equal_to_target
	{
        public int NumOfPairs(string[] nums, string target)
        {
            var dic = new Dictionary<string, int>();
            foreach (var item in nums)
            {
                if (!dic.ContainsKey(item))
                {
                    dic[item] = 0;
                }

                dic[item]++;
            }

            var res = 0;
            foreach (var item in dic)
            {
                if (target.StartsWith(item.Key))
                {
                    var suffix = target.Substring(item.Key.Length);
                    if (!dic.TryGetValue(suffix, out var suffixCount))
                    {
                        continue;
                    }

                    res += item.Value * suffixCount;

                    if (item.Key.Equals(suffix))
                    {
                        res -= item.Value;
                    }
                }
            }

            return res;
        }
    }
}

