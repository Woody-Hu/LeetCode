using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CanPlaceFlowers
    {
        public bool CanPlaceFlowersMethod(int[] flowerbed, int n)
        {
            int lastIndex = -2;
            int returnCount = 0;

            var tempLength = flowerbed.Length;

            for (int i = 0; i < tempLength; i++)
            {
                if (1 == flowerbed[i])
                {
                    returnCount = returnCount + (i - lastIndex - 2) / 2;
                    lastIndex = i;
                }
            }

            returnCount = returnCount + (tempLength - 1 - lastIndex) / 2;

            return returnCount >= n;
        }
    }
}
