using System;
namespace LeetCode
{
	public class minimum_additions_to_make_valid_string
	{
        public int AddMinimum(string word)
        {
            var n = word.Length;
            var res = 1;
            for (int i = 1; i < n; i++)
            {
                if (word[i] <= word[i - 1])
                {
                    res++;
                }
            }

            return 3 * res - n;
        }
    }
}

