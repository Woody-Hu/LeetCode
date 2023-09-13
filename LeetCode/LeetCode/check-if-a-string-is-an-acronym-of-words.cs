using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class check_if_a_string_is_an_acronym_of_words
	{
        public bool IsAcronym(IList<string> words, string s)
        {
            if (s.Length != words.Count)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (words[i][0] != s[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

