using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UTF_8_Validation
    {
        public bool ValidUtf8(int[] data)
        {
            var count = 0;
            foreach (var oneValue in data)
            {
                if (count == 0)
                {
                    var shift = 1 << 7;
                    while ((shift & oneValue) == shift && shift > 1)
                    {
                        count++;
                        shift = shift >> 1;
                    }

                    if (count == 1|| count > 4)
                    {
                        return false;
                    }
                    count = (count == 0) ? count : --count;
                }
                else
                {
                    var shift1 = 1 << 7;
                    var shift2 = 1 << 6;
                    if (count > 0 && (shift1 & oneValue) == shift1 && (shift2 & oneValue) == 0)
                    {
                        count--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return count == 0;

        }
    }
}
