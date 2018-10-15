using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SortArrayByParityII
    {
        public int[] SortArrayByParityIIMethod(int[] A)
        {
            int[] returnValue = new int[A.Length];

            int useEvenIndex = 0;
            int useOddIndex = 1;

            foreach (var oneValue in A)
            {
                if (oneValue % 2 == 0)
                {
                    returnValue[useEvenIndex] = oneValue;
                    useEvenIndex = useEvenIndex + 2;
                }
                else
                {
                    returnValue[useOddIndex] = oneValue;
                    useOddIndex = useOddIndex + 2;
                }
            }

            return returnValue;
        }
    }
}
