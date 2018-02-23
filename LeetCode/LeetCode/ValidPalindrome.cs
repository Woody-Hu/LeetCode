using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            int head = 0, tail = s.Length - 1;
            char cHead, cTail;
            while (head <= tail)
            {
                cHead = s[head];
                cTail = s[tail];

                if (!Char.IsLetterOrDigit(cHead))
                {
                    head++;
                }
                else if (!Char.IsLetterOrDigit(cTail))
                {
                    tail--;
                }
                else
                {
                    if (Char.ToLower(cHead) != Char.ToLower(cTail))
                    {
                        return false;
                    }
                    head++;
                    tail--;
                }
            }

            return true;

        }
    }
}
