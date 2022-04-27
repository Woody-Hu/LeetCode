using System;
namespace LeetCode
{
    public class palindromic_substrings
    {
        public int CountSubstrings(string s)
        {
            var length = s.Length;
            var res = 0;
            for (int i = 0; i < 2*length - 1; i++)
            {
                var left = i / 2;
                var right = i / 2 + i % 2;
                while (left >= 0 && right <= length - 1 && s[right] == s[left])
                {
                    right++;
                    left--;
                    res++;
                }
            }

            return res;
        }
    }
}
