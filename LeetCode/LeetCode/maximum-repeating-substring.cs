using System;
using System.Text;

namespace LeetCode
{
    public class maximum_repeating_substring
    {
        public int MaxRepeating(string sequence, string word)
        {
            var res = 0;
            var stringBuilder = new StringBuilder(word);
            while (sequence.Contains(stringBuilder.ToString()))
            {
                res++;
                stringBuilder.Append(word);
            }

            return res;
        }
    }
}
