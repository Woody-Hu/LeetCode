using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            var tempValue = InnerMethod(dividend, divisor);

            return tempValue > int.MaxValue ? int.MaxValue : (int)tempValue;
        }

        private long InnerMethod(long inputDividend,long inputDivisor)
        {
            var negativeTag = inputDividend < 0 != inputDivisor < 0;

            inputDividend = Math.Abs(inputDividend);

            inputDivisor = Math.Abs(inputDivisor);

            if (inputDividend < inputDivisor)
            {
                return 0;
            }

            var tempSum = inputDivisor;

            long tempCount = 1;

            while ((tempSum+tempSum)<=inputDividend)
            {
                tempSum += tempSum;
                tempCount += tempCount;
            }

            return negativeTag ? -(tempCount + InnerMethod(inputDividend - tempSum, inputDivisor)) :
                (tempCount + InnerMethod(inputDividend - tempSum, inputDivisor));
        }
    }
}
