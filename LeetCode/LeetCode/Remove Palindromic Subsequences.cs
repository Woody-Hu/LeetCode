using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Remove_Palindromic_Subsequences
    {
        public int RemovePalindromeSub(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            if (Check(s))
            {
                return 1;
            }

            return 2;
        }

        private bool Check(string s)
        {
            var i = 0;
            var j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false; 
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
