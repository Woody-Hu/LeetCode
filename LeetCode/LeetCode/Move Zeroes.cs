using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (0 == nums[i])
                {
                    for (int k = i; k < nums.Length; k++)
                    {
                        if (0 != nums[k])
                        {
                            int tempValue = 0;
                            tempValue = nums[k];
                            nums[k] = nums[i];
                            nums[i] = tempValue;
                            break;
                        }
                    }
                }
            }
        }
    }
}
