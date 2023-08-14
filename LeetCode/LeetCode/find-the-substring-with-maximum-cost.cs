using System;
namespace LeetCode
{
	public class find_the_substring_with_maximum_cost
	{
        public int MaximumCostSubstring(string s, string chars, int[] vals)
        {
            var dic = new int[26];
            for (int i = 0; i < 26; i++)
            {
                dic[i] = i + 1;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                dic[chars[i] - 'a'] = vals[i];
            }

            var res = 0;
            var temp = 0;
            foreach (var item in s)
            {
                temp = Math.Max(temp, 0) + dic[item - 'a'];
                res = Math.Max(res, temp);
            }

            return res;
        }
    }
}

