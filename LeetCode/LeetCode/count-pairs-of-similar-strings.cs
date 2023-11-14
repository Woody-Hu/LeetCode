using System;
namespace LeetCode
{
	public class count_pairs_of_similar_strings
	{
        public int SimilarPairs(string[] words)
        {
            var len = words.Length;
            var masks = new int[len];
            for (int i = 0; i < len; i++)
            {
                foreach (var item in words[i])
                {
                    masks[i] = masks[i] | (1 << (item - 'a'));
                }
            }

            var res = 0;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (masks[i] == masks[j])
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}

