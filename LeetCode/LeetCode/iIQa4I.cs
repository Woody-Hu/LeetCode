using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class iIQa4I
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var length = temperatures.Length;
            var res = new int[length];
            var stack = new Stack<int>();
            for (int i = 0; i < length; i++)
            {
                var t = temperatures[i];
                while (stack.Any() && t > temperatures[stack.Peek()])
                {
                    var p = stack.Pop();
                    res[p] = i - p;
                }

                stack.Push(i);
            }

            return res;
        }
    }
}
