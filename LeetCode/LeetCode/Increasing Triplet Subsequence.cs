using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Increasing_Triplet_Subsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            var first = int.MaxValue;
            var second = int.MaxValue;

            foreach (var value in nums)
            {
                if (value <= first)
                {
                    first = value;
                }
                else if (value <= second)
                {
                    second = value;
                }
                else
                {
                    return true;
                }
            }

            return false;

        }
    }
}
