using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Decompress_Run_Length_Encoded_List
    {
        public int[] DecompressRLElist(int[] nums)
        {
            var res = new List<int>();
            for (int i = 0; i < nums.Length; i = i + 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    res.Add(nums[i + 1]);
                }
            }

            return res.ToArray();
        }
    }
}
