using System;
namespace LeetCode
{
    public class count_substrings_with_only_one_distinct_letter
    {
        public int CountLetters(string s)
        {
            var res = 0;
            var currentCount = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    res += currentCount * (currentCount + 1) / 2;
                    currentCount = 1;
                }
            }

            res += currentCount * (currentCount + 1) / 2;
            return res;
        }
    }
}
