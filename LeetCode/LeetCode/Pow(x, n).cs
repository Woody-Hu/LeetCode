using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Pow_x__n_
    {
        public double MyPow(double x, int n)
        {
            var returnValue = InnerPow(x, n);

            if (n < 0)
            {
                returnValue = 1.0 / returnValue;
            }

            return returnValue;
        }

        private double InnerPow(double x, int n)
        {
            if (n == 0)
            {
                return 1.0;
            }


            var nextValue = InnerPow(x, n / 2);

            if ((n % 2) == 0)
            {
                return nextValue * nextValue;
            }

            return nextValue * nextValue * x;
        }
    }
}
