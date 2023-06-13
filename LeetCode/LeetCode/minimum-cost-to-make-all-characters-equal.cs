using System;
namespace LeetCode
{
	public class minimum_cost_to_make_all_characters_equal
	{
        public long MinimumCost(string s)
        {
            long res = 0;
            var array = s.ToCharArray();
            var n = s.Length;
            for (int i = 1; i < n; i++)
            {
                if (s[i - 1] != s[i])
                {
                    res += Math.Min(i, n - i);
                }
            }

            return res;
        }
    }
}

