using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int length = s.Length;

            if (length < 2)
            {
                return s;
            }

            int useStartIndex = 0;
            int useLength = 0;

            for (int i = 0; i < length; i++)
            {
                InnerMethod(s, i, i, ref useStartIndex, ref useLength);
                InnerMethod(s, i, i+1, ref useStartIndex, ref useLength);
            }

            return s.Substring(useStartIndex, useLength);
        }

        private void InnerMethod(string s,int startIndex,int endIndex,ref int useStartIndex,ref int useLength)
        {
            while (startIndex >=0 && endIndex < s.Length && s[startIndex] == s[endIndex])
            {
                startIndex--;
                endIndex++;
            }

            if (endIndex - startIndex - 1 > useLength)
            {
                useStartIndex = startIndex+1;
                useLength = endIndex - startIndex - 1;
            }
        }
    }
}
