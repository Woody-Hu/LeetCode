using System;
using System.Linq;

namespace LeetCode
{
	public class count_prefixes_of_a_given_string
	{
        public int CountPrefixes(string[] words, string s)
        {
            return words.Count(k => s.StartsWith(k, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}

