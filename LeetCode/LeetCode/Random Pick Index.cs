using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Random_Pick_Index
    {
        private int[] _nums;
        private Random _random = new Random();

        public Random_Pick_Index(int[] nums)
        {
            _nums = nums;
        }

        public int Pick(int target)
        {
            var count = 0;
            var res = 0;
            for (int i = 0; i < _nums.Length; i++)
            {
                if (_nums[i]!= target)
                {
                    continue;
                }

                if (_random.Next(++count) == 0)
                {
                    res = i;
                }

            }

            return res;
        }
    }
}
