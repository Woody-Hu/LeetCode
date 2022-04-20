using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class sum_of_subarray_minimums
    {
        private readonly long _mod = 1000000007;

        public int SumSubarrayMins(int[] arr)
        {
            var lefts = new int[arr.Length];
            var rights = new int[arr.Length];
            var stack = new Stack<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                while (stack.Any() && arr[i] < arr[stack.Peek()])
                {
                    stack.Pop();
                }

                if (!stack.Any())
                {
                    lefts[i] = -1;
                }
                else
                {
                    lefts[i] = stack.Peek();
                }

                stack.Push(i);
            }

            stack = new Stack<int>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                while (stack.Any() && arr[i] <= arr[stack.Peek()])
                {
                    stack.Pop();
                }

                if (!stack.Any())
                {
                    rights[i] = arr.Length;
                }
                else
                {
                    rights[i] = stack.Peek();
                }

                stack.Push(i);
            }

            long res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res = (res + (long)(i - lefts[i]) * (rights[i] - i) * arr[i]) % _mod;
            }

            return (int)res;
        }
    }
}
