using System;
namespace LeetCode
{
    public class construct_k_palindrome_strings
    {
        public bool CanConstruct(string s, int k)
        {
            var right = s.Length;
            var array = new int[26];
            foreach (var item in s)
            {
                array[item - 'a']++;
            }

            var left = 0;
            foreach (var item in array)
            {
                if (item % 2 == 1)
                {
                    left++;
                }
            }

            left = Math.Max(left, 1);
            return left <= k && k <= right;
        }
    }
}

