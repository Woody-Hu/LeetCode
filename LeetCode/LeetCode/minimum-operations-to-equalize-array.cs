using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class minimum_operations_to_equalize_array
    {
        public int MinOperations(int[] nums)
        {

            int n = nums.Length;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] != nums[0])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
