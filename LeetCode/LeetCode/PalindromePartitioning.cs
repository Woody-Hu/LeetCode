using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var returnValue = new List<IList<string>>();
            Partition(s, new List<string>(), returnValue);
            return returnValue;
        }

        private void Partition(string s, IList<string> visited, IList<IList<string>> returnValue)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                returnValue.Add(new List<string>(visited));
            }

            for (var i = 0; i < s.Length; i++)
            {
                var subString = s.Substring(0, i + 1);
                if (!IsPalindrome(subString))
                {
                    continue;
                }

                visited.Add(subString);
                Partition(s.Substring(i+1), visited, returnValue);
                visited.RemoveAt(visited.Count-1);
            }
        }

        private bool IsPalindrome(string s)
        {
            var startIndex = 0;
            var endIndex = s.Length - 1;
            while (startIndex < endIndex)
            {
                if (s[startIndex] != s[endIndex])
                {
                    return false;
                }

                startIndex++;
                endIndex--;
            }

            return true;
        }
    }
}
