using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class build_an_array_with_stack_operations
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var res = new List<string>();
            var index = 0;
            for (int i = 1; i <= n; i++)
            {
                if (target[target.Length - 1] <i)
                {
                    break;
                }

                res.Add("Push");
                if (target[index] > i)
                {
                    res.Add("Pop");
                }
                else
                {
                    index++;
                }
            }

            return res;
        }
    }
}
