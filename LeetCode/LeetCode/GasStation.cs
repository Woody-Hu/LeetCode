using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var length = gas.Length;
            var sum = 0;
            var calculatedValue = 0;
            var useIndex = 0;

            for (var i = 0; i < length; i++)
            {
                calculatedValue += gas[i] - cost[i];
                if (calculatedValue < 0)
                {
                    sum += calculatedValue;
                    calculatedValue = 0;
                    useIndex = i + 1;
                }
            }
            sum += calculatedValue;
            return sum < 0 ? -1 : useIndex;

        }
    }
}
