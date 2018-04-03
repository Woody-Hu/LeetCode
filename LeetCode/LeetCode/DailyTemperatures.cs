using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class DailyTemperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<int> useStack = new Stack<int>();
            int[] returnValue = new int[temperatures.Length];
            for (int tempIndex = 0; tempIndex < temperatures.Length; tempIndex++)
            {
                while (useStack.Count != 0 && temperatures[tempIndex] > temperatures[useStack.Peek()])
                {
                    var tempAnotherIndex = useStack.Pop();

                    returnValue[tempAnotherIndex] = tempIndex - tempAnotherIndex;
                }
                useStack.Push(tempIndex);
            }
            return returnValue;
        }
    }
}
