using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ScrambleString
    {
        public bool IsScramble(string s1, string s2)
        {
            if (s1.Equals(s2))
            {
                return true;
            }

            if (s1.Length != s2.Length)
            {
                return false;
            }

            int[] ls = new int[26];

            int length = s1.Length;

            for (int i = 0; i < length; i++)
            {
                ls[s1[i] - 'a']++;
                ls[s2[i] - 'a']--;
            }

            foreach (var oneLetter in ls)
            {
                if (oneLetter != 0)
                {
                    return false;
                }
            }

            for (int i = 1; i < length; i++)
            {
                if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i)))
                {
                    return true;
                }

                if (IsScramble(s1.Substring(0, i), s2.Substring(length - i)) && IsScramble(s2.Substring(0, length - i), s1.Substring(i)))
                {
                    return true;
                }
            }

            return false;

        }
    }
}
