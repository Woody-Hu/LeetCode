using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class count_the_number_of_vowel_strings_in_range
	{
        public int VowelStrings(string[] words, int left, int right)
        {
            var res = 0;
            var set = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
            for (int i = left; i <= right; i++)
            {
                var str = words[i];
                if (set.Contains(str[0]) && set.Contains(str[str.Length - 1]))
                {
                    res++;
                }
            }

            return res;
        }
    }
}

