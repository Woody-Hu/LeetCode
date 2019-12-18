using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
    {
        public int SubtractProductAndSum(int n)
        {
            var sum = 0;
            var pro = 1;

            while (n != 0)
            {
                var digt = n % 10;
                sum += digt;
                pro *= digt;
                n /= 10;
            }

            return pro - sum;
        }
    }
}
