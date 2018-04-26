using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Base7
    {
        public string ConvertToBase7(int num)
        {
            if (num == 0)
            {
                return "0";
            }

            bool isSubZero = num < 0;
            string returnValue = string.Empty;
            while (num != 0)
            {
                returnValue = Math.Abs((num % 7)) + returnValue;
                num /= 7;
            }

            return isSubZero ? "-" + returnValue : returnValue;
        }
    }
}
