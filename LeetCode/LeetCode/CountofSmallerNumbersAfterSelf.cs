using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CountofSmallerNumbersAfterSelf
    {
        public IList<int> CountSmaller(int[] nums)
        {
            int[] returnValue = new int[nums.Length];

            List<int> lstTempValue = new List<int>();

            for (int i = nums.Count() - 1; i >=0; i--)
            {
                int left = 0, right = lstTempValue.Count;

                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (lstTempValue[mid] >= nums[i]) right = mid;
                    else left = mid + 1;
                }

                returnValue[i] = right;

                lstTempValue.Insert(right, nums[i]);
            }

            return returnValue.ToList();
        }
    }
}
