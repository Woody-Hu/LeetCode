using System;
namespace LeetCode
{
	public class minimum_deletions_to_make_string_balanced
	{
        public int MinimumDeletions(string s)
        {
            var ca = 0;
            foreach (var item in s)
            {
                ca += 'b' - item;
            }

            var res = ca;
            foreach (var item in s)
            {
                ca += (item - 'a') * 2 - 1;
                res = Math.Min(ca, res);
            }

            return res;
        }
    }
}

