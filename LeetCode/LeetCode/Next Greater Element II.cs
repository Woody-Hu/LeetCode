using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Next_Greater_Element_II
    {
        public int[] NextGreaterElements(int[] nums)
        {
            var length = nums.Length;
            var res = new int[nums.Length];
            var stack = new Stack<KeyValuePair<int,int>>();
            UpdateArray(nums, length, stack, res,true);
            UpdateArray(nums, length, stack, res,false);
            while (stack.Count != 0)
            {
                var pair = stack.Pop();
                res[pair.Key] = -1;
            }

            return res;
        }

        private static void UpdateArray(int[] nums, int length, Stack<KeyValuePair<int, int>> stack, int[] res, bool pushValue)
        {
            for (int i = 0; i < length; i++)
            {
                var num = nums[i];
                while (stack.Count != 0 && stack.Peek().Value < num)
                {
                    var pair = stack.Pop();
                    res[pair.Key] = num;
                }

                if (pushValue)
                {
                    stack.Push(new KeyValuePair<int, int>(i, num));
                }
            }
        }
    }
}
