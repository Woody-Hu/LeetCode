using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestPalindrome
    {
        public int LongestPalindromeMethod(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var groupedValue = s.GroupBy(k => k).OrderBy(k => -k.Count());

            if (1 == groupedValue.ElementAt(0).Count())
            {
                return 1;
            }

            int returnValue = 0;
            bool ifFonudSingle = false;

            foreach (var oneValue in groupedValue)
            {
                int tempValue = oneValue.Count();
                if (tempValue % 2 == 0)
                {
                    returnValue = returnValue + tempValue;
                }
                else
                {
                    if (!ifFonudSingle)
                    {
                        ifFonudSingle = true;
                    }

                    returnValue = returnValue + tempValue - 1;

                    if (1 == tempValue)
                    {
                        break;
                    }
                }
            }

            if (ifFonudSingle)
            {
                returnValue += 1;
            }

            return returnValue;


        }
    }
}
