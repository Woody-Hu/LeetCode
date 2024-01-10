using System;
using System.Collections.Generic;
namespace LeetCode
{
	public class maximum_strong_pair_xor_i
	{
        public int MaximumStrongPairXor(int[] nums)
        {
            Array.Sort(nums);
            var hiBit = 31 - NumberOfLeadingZeros(nums[nums.Length - 1]);
            var result = 0;
            var mask = 0;
            var dic = new Dictionary<int, int>();
            for (var i = hiBit; i >= 0; i--)
            {
                dic.Clear();
                mask |= (1 << i);
                var newResult = result | (1 << i);
                foreach (var num in nums)
                {
                    var maskY = num & mask;
                    var key = num & mask;
                    if(dic.ContainsKey(newResult ^ maskY) && dic[newResult ^ maskY]* 2 >= num)
                    {
                        result = newResult;
                        break;
                    }

                    dic[key] = num;
                }
            }

            return result;
        }

        private int NumberOfLeadingZeros(int n)
        {
            if (n == 0)
                return 32;
            var count = 0;
            while (n > 0)
            {
                n >>= 1;
                count++;
            }

            return count;
        }
    }
}

