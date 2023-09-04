using System;
using System.Linq;

namespace LeetCode
{
	public class check_if_strings_can_be_made_equal_with_operations_ii
	{
        public bool CheckStrings(string s1, string s2)
        {
            var count1 = new int[2][];
            var count2 = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                count1[i] = new int[26];
                count2[i] = new int[26];
            }

            for (int i = 0; i < s1.Length; i++)
            {
                count1[i % 2][s1[i] - 'a']++;
                count2[i % 2][s2[i] - 'a']++;
            }

            return Enumerable.SequenceEqual(count1[0], count2[0]) && Enumerable.SequenceEqual(count1[1], count2[1]);
        }
    }
}

