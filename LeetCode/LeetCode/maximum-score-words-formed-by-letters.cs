using System;
namespace LeetCode
{
	public class maximum_score_words_formed_by_letters
	{
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            var n = words.Length;
            var res = 0;
            var count = new int[26];
            foreach (var item in letters)
            {
                count[item - 'a']++;
            }

            for (int s = 1; s < (1 << n); s++)
            {
                var wordCount = new int[26];
                for (int k = 0; k < n; k++)
                {
                    if ((s&(1 << k)) == 0)
                    {
                        continue;
                    }

                    foreach (var item in words[k])
                    {
                        wordCount[item - 'a']++;
                    }
                }

                var ok = true;
                var sum = 0;
                for (int i = 0; i < 26; i++)
                {
                    sum += score[i] * wordCount[i];
                    ok = ok && (wordCount[i] <= count[i]);
                }

                if (ok)
                {
                    res = Math.Max(res, sum);
                }
            }

            return res;
        }
    }
}

