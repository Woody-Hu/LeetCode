using System;
using System.Text;

namespace LeetCode
{
	public class largest_merge_of_two_strings
	{
        public string LargestMerge(string word1, string word2)
        {
            var res = new StringBuilder();
            var i = 0;
            var j = 0;
            while (i < word1.Length || j < word2.Length)
            {
                if (i < word1.Length && word1.Substring(i).CompareTo(word2.Substring(j)) > 0)
                {
                    res.Append(word1[i]);
                    i++;
                }
                else
                {
                    res.Append(word2[j]);
                    j++;
                }
            }

            return res.ToString();
        }
    }
}

