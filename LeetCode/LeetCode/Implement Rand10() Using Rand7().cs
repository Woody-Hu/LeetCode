using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Implement_Rand10___Using_Rand7__
    {
        public int Rand10()
        {
            var a = 7;
            var b = 7;
            while (a == 7)
            {
                a = Rand7();
            }

            while (b > 5)
            {
                b = Rand7();
            }

            return b + (a < 4 ? 5:0);
        }

        private int Rand7()
        {
            return (new Random()).Next(1,8);
        }
    }
}
