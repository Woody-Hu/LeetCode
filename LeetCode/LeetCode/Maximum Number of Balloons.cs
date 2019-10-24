using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximum_Number_of_Balloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            var res = 0;
            var array = new int[26];
            foreach (var oneChar in text)
            {
                array[oneChar - 'a']++;
            }

            var str = "balloon";
            var ifBreak = false;
            while (!ifBreak)
            {
                foreach (var oneChar in str)
                {
                    var index = oneChar - 'a';
                    if (array[index] > 0)
                    {
                        array[index]--;
                    }
                    else
                    {
                        ifBreak = true;
                        break;
                    }
                }

                if (!ifBreak)
                {
                    res++;
                }
            }

            return res;
        }
    }
}
