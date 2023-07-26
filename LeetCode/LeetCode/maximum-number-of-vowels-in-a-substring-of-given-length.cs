using System;
namespace LeetCode
{
	public class maximum_number_of_vowels_in_a_substring_of_given_length
	{
        public int MaxVowels(string s, int k)
        {
            var n = s.Length;
            var c = 0;
            for (int i = 0; i < k; i++)
            {
                c += IsVowel(s[i]);
            }

            var res = c;
            for (int i = k; i < n; i++)
            {
                c += IsVowel(s[i]) - IsVowel(s[i - k]);
                res = Math.Max(res, c);
            }

            return res;
        }

        private int IsVowel(char ch)
        {
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ? 1 : 0;
        }
    }
}

