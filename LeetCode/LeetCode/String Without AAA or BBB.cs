using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class String_Without_AAA_or_BBB
    {
        public string StrWithout3a3b(int A, int B)
        {
            var charArray = new char[A + B];
            var index = 0;

            for (; A + B > 0; index++)
            {
                if (index > 1 && charArray[index - 1] == charArray[index - 2])
                {
                    if (charArray[index - 1] == 'a')
                    {
                        charArray[index] = 'b';
                        B--;
                    }
                    else
                    {
                        charArray[index] = 'a';
                        A--;
                    }
                }
                else if (A > B)
                {
                    charArray[index] = 'a';
                    A--;
                }
                else
                {
                    charArray[index] = 'b';
                    B--;
                } 
            }
            return new string(charArray);

        }
    }
}
