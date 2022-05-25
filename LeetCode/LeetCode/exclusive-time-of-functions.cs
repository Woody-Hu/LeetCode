using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class exclusive_time_of_functions
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            var stack = new Stack<int>();
            var res = new int[n];
            var s = logs[0].Split(":");
            stack.Push(int.Parse(s[0]));
            var i = 1;
            var prev = int.Parse(s[2]);
            while (i < logs.Count)
            {
                s = logs[i].Split(":");
                if (s[1].Equals("start"))
                {
                    if (stack.Any())
                        res[stack.Peek()] += int.Parse(s[2]) - prev;
                    stack.Push(int.Parse(s[0]));
                    prev = int.Parse(s[2]);
                }
                else
                {
                    res[stack.Peek()] += int.Parse(s[2]) - prev + 1;
                    stack.Pop();
                    prev = int.Parse(s[2]) + 1;
                }

                i++;
            }

            return res;
        }
    }
}
