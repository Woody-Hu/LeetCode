using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class N_th_Tribonacci_Number
    {
        public int Tribonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }

            var a = 0;
            var b = 1;
            var c = 1;
            while (n-->2)
            {
                var d = a + b + c;
                a = b;
                b = c;
                c = d;
            }

            return c;
        }
    }
}
