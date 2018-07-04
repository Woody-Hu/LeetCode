using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length <= 2)
            {
                return true;
            }

            int leftIndex = 0;

            int rightIndex = s.Length - 1;

            while (leftIndex < rightIndex && s[leftIndex] == s[rightIndex])
            {
                leftIndex++;
                rightIndex--;
            }

            if (leftIndex <= rightIndex)
            {
                return InnerMethod(s.Substring(leftIndex, rightIndex - leftIndex)) || InnerMethod(s.Substring(leftIndex + 1, rightIndex - leftIndex));
            }


            return true;
        }

        private bool InnerMethod(string s)
        {
            int leftIndex = 0;

            int rightIndex = s.Length - 1;

            while (leftIndex <= rightIndex)
            {
                if (s[leftIndex] != s[rightIndex])
                    return false;
                leftIndex++;
                rightIndex--;
            }
            return true;

        }
    }
}
