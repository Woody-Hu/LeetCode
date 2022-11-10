using System;
namespace LeetCode
{
    public class length_of_the_longest_alphabetical_continuous_substring
    {
        public int LongestContinuousSubstring(string s)
        {
            var res = 1;
            var count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] - s[i - 1] == 1)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                res = Math.Max(res, count);
            }

            return res;
        }
    }
}
