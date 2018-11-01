
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Subsets
    {
        public IList<IList<int>> SubsetsMethod(int[] nums)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();
            Array.Sort(nums);

            List<int> useList = new List<int>();
            GetSub(returnValue, useList, nums, 0);
            returnValue.Add(new List<int>());
            return returnValue;
        }

        private void GetSub(IList<IList<int>> returnValue, List<int> useList, int[] nums, int startIndex)
        {
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                useList.Add(nums[i]);
                returnValue.Add(new List<int>(useList));

                GetSub(returnValue, useList, nums, i + 1);
                useList.RemoveAt(useList.Count - 1);
            }
        }
    }
}