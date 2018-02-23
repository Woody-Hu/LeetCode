using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PrimeNumberofSetBitsinBinaryRepresentation
    {
        public int CountPrimeSetBits(int L, int R)
        {
            int returnValue = 0;
            HashSet<int> useSet = new HashSet<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            int count = 0;
            int backValue;

            for (int i = L; i <= R; i++)
            {
                count = 0;
                backValue = i;

                for (; backValue > 0; backValue = backValue >> 1)
                {
                    count += backValue & 1;
                }

                if (useSet.Contains(count))
                {
                    returnValue++;
                }
            }

            return returnValue;
        }
    }
}
