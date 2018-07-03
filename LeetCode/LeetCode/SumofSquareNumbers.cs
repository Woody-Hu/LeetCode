using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SumofSquareNumbers
    {
        public bool JudgeSquareSum(int c)
        {
            if (0 == c)
            {
                return true;
            }

            var tempValue = 1;

            while (c - (tempValue * tempValue) >= 0)
            {
                var tempSubValue = c - (tempValue * tempValue);

                if (Math.Sqrt(tempSubValue) % 1 == 0)
                {
                    return true;
                }
                tempValue++;
            }

            return false;

        }
    }
}
