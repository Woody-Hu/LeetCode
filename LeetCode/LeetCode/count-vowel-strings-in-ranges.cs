using System;
namespace LeetCode
{
	public class count_vowel_strings_in_ranges
	{
        public int[] VowelStrings(string[] words, int[][] queries)
        {
            var n = words.Length;
            var pSum = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                var value = IsVowelString(words[i]) ? 1 : 0;
                pSum[i + 1] = pSum[i] + value;
            }

            var res = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                res[i] = pSum[queries[i][1] + 1] - pSum[queries[i][0]];
            }

            return res;
        }

        private bool IsVowelString(string s)
        {
            return IsVowelLetter(s[0]) && IsVowelLetter(s[s.Length - 1]);
        }

        private bool IsVowelLetter(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}

