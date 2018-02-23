using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ProductofArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            if (null == nums || 0 == nums.Length)
            {
                return nums;
            }

            int sumValue = 1;

            List<int> zeroIndex = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (0 == nums[i])
                {
                    zeroIndex.Add(i);
                    continue;
                }
                sumValue = sumValue * nums[i];
            }

            int[] returnValue = new int[nums.Length];



            if (0 == zeroIndex.Count)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    returnValue[i] = sumValue / nums[i];
                }
            }
            else if (1 < zeroIndex.Count)
            {
                return returnValue;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (zeroIndex.Contains(i))
                    {
                        if (zeroIndex.Count == nums.Length)
                        {
                            returnValue[i] = 0;
                            continue;
                        }
                        returnValue[i] = sumValue;
                    }
                    else
                    {
                        returnValue[i] = 0;
                    }
                }

            }
            return returnValue;
        }
    }
}
