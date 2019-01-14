using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Fibonacci_Number
    {
        public int Fib(int N)
        {
            if (N <= 1)
            {
                return N;
            }

            var value1 = 0;
            var value2 = 1;

            for (int i = 2; i <= N; i++)
            {
                var sum = value2 + value1;
                value1 = value2;
                value2 = sum;
            }

            return value2;
        }
    }
}
