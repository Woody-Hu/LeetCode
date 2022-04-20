using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class sum_of_subarray_ranges
    {
        public long SubArrayRanges(int[] nums)
        {
            var leftMin = new int[nums.Length];
            var leftMax = new int[nums.Length];
            var rightMin = new int[nums.Length];
            var rightMax = new int[nums.Length];

            var minStack = new Stack<int>();
            var maxStack = new Stack<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                while (minStack.Any() && nums[minStack.Peek()] > nums[i])
                {
                    minStack.Pop();
                }

                if (!minStack.Any())
                {
                    leftMin[i] = -1;
                }
                else
                {
                    leftMin[i] = minStack.Peek();
                }

                minStack.Push(i);

                while (maxStack.Any() && nums[maxStack.Peek()] <= nums[i])
                {
                    maxStack.Pop();
                }

                if (!maxStack.Any())
                {
                    leftMax[i] = -1;
                }
                else
                {
                    leftMax[i] = maxStack.Peek();
                }

                maxStack.Push(i);

            }

            minStack = new Stack<int>();
            maxStack = new Stack<int>();
            for (int i = nums.Length -1; i >= 0; i--)
            {
                while (minStack.Any() && nums[minStack.Peek()] >= nums[i])
                {
                    minStack.Pop();
                }

                if (!minStack.Any())
                {
                    rightMin[i] = nums.Length;
                }
                else
                {
                    rightMin[i] = minStack.Peek();
                }

                minStack.Push(i);

                while (maxStack.Any() && nums[maxStack.Peek()] < nums[i])
                {
                    maxStack.Pop();
                }

                if (!maxStack.Any())
                {
                    rightMax[i] = nums.Length;
                }
                else
                {
                    rightMax[i] = maxStack.Peek();
                }

                maxStack.Push(i);

            }

            long sumMax = 0, sumMin = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sumMax += (long)(rightMax[i] - i) * (i - leftMax[i]) * nums[i];
                sumMin += (long)(rightMin[i] - i) * (i - leftMin[i]) * nums[i];
            }


            return sumMax - sumMin;
        }
    }
}
