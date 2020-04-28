using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Number_of_Steps_to_Reduce_a_Number_to_Zero
    {
        public int NumberOfSteps(int num)
        {
            var res = 0;
            while (num != 0)
            {
                res++;
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
            }

            return res;
        }
    }
}
