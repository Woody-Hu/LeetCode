using System;
namespace LeetCode
{
    public class find_the_longest_substring_containing_vowels_in_even_counts
    {
        public int FindTheLongestSubstring(string s)
        {
            var list = new int[1 << 5];
            for (int i = 0; i < list.LongLength; i++)
            {
                list[i] = int.MaxValue;
            }

            list[0] = -1;
            var mask = 0;
            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'a': mask ^= (1 << 0); break;
                    case 'e': mask ^= (1 << 1); break;
                    case 'i': mask ^= (1 << 2); break;
                    case 'o': mask ^= (1 << 3); break;
                    case 'u': mask ^= (1 << 4); break;
                    default:
                        break;
                }

                if (list[mask] == int.MaxValue)
                {
                    list[mask] = i;
                }
                else
                {
                    res = Math.Max(res, i - list[mask]);
                }
            }

            return res;
        }
    }
}
