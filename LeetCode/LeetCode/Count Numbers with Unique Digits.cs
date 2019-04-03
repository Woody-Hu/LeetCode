using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Count_Numbers_with_Unique_Digits
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0) return 1;

            int res = 10;
            int uniqueDigits = 9;
            int availableNumber = 9;
            while (n-- > 1 && availableNumber > 0)
            {
                uniqueDigits = uniqueDigits * availableNumber;
                res += uniqueDigits;
                availableNumber--;
            }
            return res;
        }
    }
}
