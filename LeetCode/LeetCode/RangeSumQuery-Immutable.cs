using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NumArray2
    {
        int[] m_useNums;

        public NumArray2(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
                nums[i] += nums[i - 1];

            this.m_useNums = nums;
        }

        public int SumRange(int i, int j)
        {
            if (0 == i)
            {
                return m_useNums[j];
            }

            return m_useNums[j] - m_useNums[i - 1];
        }
    }
}
