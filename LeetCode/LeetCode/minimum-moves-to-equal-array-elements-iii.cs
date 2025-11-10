using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class minimum_moves_to_equal_array_elements_iii
    {
        public int MinMoves(int[] nums)
        {
            int maxNum = nums[0];
            foreach (int num in nums)
            {
                maxNum = Math.Max(maxNum, num);
            }
            int moves = 0;
            foreach (int num in nums)
            {
                moves += maxNum - num;
            }

            return moves;
        }
    }
}
