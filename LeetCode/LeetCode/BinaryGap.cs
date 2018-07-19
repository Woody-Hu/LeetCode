using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class BinaryGap
    {
        public int BinaryGapMethod(int N)
        {
            int tempCount = 0;

            int nowMaxCount = 0;

            bool ifVisitedFirst = true;

            while (0 != N)
            {
                var tempValue = N % 2;

                if (1 == tempValue)
                {
                    if (ifVisitedFirst)
                    {
                        ifVisitedFirst = false;
                    }
                    else
                    {
                        nowMaxCount = Math.Max(nowMaxCount, tempCount + 1);
                    }

                    tempCount = 0;
                }
                else if (!ifVisitedFirst)
                {
                    tempCount++;
                }

                N = N / 2;
            }

            return nowMaxCount;

        }
    }
}