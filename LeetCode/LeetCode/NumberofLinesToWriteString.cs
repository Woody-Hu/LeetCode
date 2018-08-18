using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NumberofLinesToWriteString
    {
        public int[] NumberOfLines(int[] widths, string S)
        {
            int nowValue = 0;
            int nowRowCount = 1;

            foreach (var oneChar in S)
            {
                var tempValue = widths[oneChar - 'a'];

                if (nowValue + tempValue > 100)
                {
                    nowValue = tempValue;
                    nowRowCount++;
                }
                else
                {
                    nowValue = nowValue + tempValue;
                }
            }

            return new int[] { nowRowCount, nowValue };

        }
    }
}
