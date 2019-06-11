using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Circular_Array_Loop
    {
        public bool CircularArrayLoop(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                {
                    continue;
                }

                int j = i, k = getNext(j, nums);
                while (nums[i] * nums[k] > 0 && nums[i] * nums[getNext(k, nums)] > 0)
                {
                    if (j == k)
                    {
                        if (j == getNext(j, nums))
                        {
                            break;
                        }
                        return true;
                    }
                    j = getNext(j, nums);
                    k = getNext(getNext(k, nums), nums);
                }

                j = i;
                while (nums[j] * nums[i] > 0)
                {
                    var next = getNext(j, nums);
                    nums[j] = 0;
                    j = next;
                }
            }
            return false;
        }

        private int getNext(int j, int[] nums)
        {
            int n = nums.Length;
            return j + nums[j] >= 0 ? (j + nums[j]) % n : (n + ((j + nums[j]) % n))%n;
        }
    }
}
