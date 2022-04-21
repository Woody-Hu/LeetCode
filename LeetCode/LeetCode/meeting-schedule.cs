using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class meeting_schedule
    {
        public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            var ordered1 = slots1.OrderByDescending(k => k[0]);
            var ordered2 = slots2.OrderByDescending(k => k[0]);
            var stack1 = new Stack<int[]>();
            var stack2 = new Stack<int[]>();
            foreach (var item in ordered1)
            {
                stack1.Push(item);
            }

            foreach (var item in ordered2)
            {
                stack2.Push(item);
            }

            while (stack1.Any() && stack2.Any())
            {
                var value1 = stack1.Pop();
                var value2 = stack2.Pop();
                var stak1EndFirst = value1[1] < value2[1];
                var maxStart = Math.Max(value1[0], value2[0]);
                var minEnd = Math.Min(value1[1], value2[1]);
                if (minEnd - maxStart < duration)
                {
                    if (stak1EndFirst)
                    {
                        stack2.Push(value2);
                    }
                    else
                    {
                        stack1.Push(value1);
                    }

                    continue;
                }

                return new List<int>() { maxStart, maxStart + duration };
            }

            return new List<int>();
        }
    }
}
