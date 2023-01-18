using System;
using System.Linq;

namespace LeetCode
{
    public class binary_string_with_substrings_representing_1_to_n
    {
        public bool QueryString(string s, int n)
        {
            var l = s.Length;
            if (n > l*l)
            {
                return false;
            }

            return Enumerable.Range(1, n).All(c => s.Contains(Convert.ToString(c, 2)));
        }
    }
}
