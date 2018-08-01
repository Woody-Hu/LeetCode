using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Heaters
    {
        public int FindRadius(int[] houses, int[] heaters)
        {
            Array.Sort(houses);
            Array.Sort(heaters);

            int useHeaterIndex = 0;
            int returnValue = 0;

            foreach (var oneHouseValue in houses)
            {
                while (useHeaterIndex < heaters.Length - 1 && (heaters[useHeaterIndex] + heaters[useHeaterIndex + 1]) <= 2*oneHouseValue)
                {
                    useHeaterIndex++;
                }

                returnValue = Math.Max(returnValue, Math.Abs(heaters[useHeaterIndex] - oneHouseValue));
            }

            return returnValue;
        }
    }
}
