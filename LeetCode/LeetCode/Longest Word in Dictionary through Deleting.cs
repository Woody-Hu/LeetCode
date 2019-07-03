using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Longest_Word_in_Dictionary_through_Deleting
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            var res = string.Empty;

            foreach (var oneItem in d)
            {
                if (oneItem.Length < res.Length || (oneItem.Length == res.Length && string.Compare(oneItem, res) >= 0))
                {
                    continue;
                }

                if (IsSubString(oneItem, s))
                {
                    res = oneItem;
                }
            }

            return res;
        }

        private bool IsSubString(string s, string target)
        {
            var i = 0;
            var j = 0;
            if (s.Length > target.Length)
            {
                return false;
            }

            while (i < s.Length && j< target.Length)
            {
                if (s[i] == target[j])
                {
                    i++;
                }

                j++;
            }

            return i == s.Length;
        }
    }
}
