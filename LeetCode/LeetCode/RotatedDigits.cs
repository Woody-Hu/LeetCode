using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RotatedDigits
    {
        public int RotatedDigitsMethod(int N)
        {
            int returnValue = 0;
            for (int i = 1; i <= N; i++)
            {
                if (check(i))
                {
                    returnValue++;
                }
            }

            return returnValue;
        }

        private bool check(int input)
        {
            bool returnValue = false;

            while (input > 0)
            {
                if (input % 10 == 2 || input % 10 == 5 || input % 10 == 6 || input % 10 == 9 )
                {
                    returnValue = true;
                }
                else if (input % 10 == 3 || input % 10 == 4 || input % 10 == 7)
                {
                    return false;
                }

                input = input / 10;
            }

            return returnValue;
        }

    }
}
