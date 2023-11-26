using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_words_containing_character
	{
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            var res = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    res.Add(i);
                }
            }

            return res;
        }
    }
}

