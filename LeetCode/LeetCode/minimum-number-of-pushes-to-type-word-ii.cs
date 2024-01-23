using System;
namespace LeetCode
{
	public class minimum_number_of_pushes_to_type_word_ii
	{
        public int MinimumPushes(string word)
        {
            var cnt = new int[26];
            foreach (var item in word.ToCharArray())
            {
                cnt[item - 'a']++;
            }

            Array.Sort(cnt);

            var res = 0;
            for (int i = 0; i < 26; i++)
            {
                res += cnt[25 - i] * (i / 8 + 1);
            }

            return res;
        }
    }
}

