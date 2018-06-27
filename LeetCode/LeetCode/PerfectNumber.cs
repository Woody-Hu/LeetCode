using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PerfectNumber
    {
        public bool CheckPerfectNumber(int num)
        {
            if (1 == num)
            {
                return false;
            }

            int tempSum=0;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    tempSum += i + num / i;
                }
            }
            tempSum++;

            return num == tempSum;
        }
    }
}
