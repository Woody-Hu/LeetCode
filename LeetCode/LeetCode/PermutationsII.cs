using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> returnValue = new List<IList<int>>();

            bool[] visitTag = new bool[nums.Length];
            Array.Sort(nums);
            List<int> lstValue = new List<int>();
            InnerMethod(nums, lstValue, returnValue, visitTag);
            return returnValue;
        }

        private void InnerMethod(int[] nums,List<int> lstInputValue, IList<IList<int>> returnValue,bool[] inputTag)
        {
            if (lstInputValue.Count == nums.Length)
            {
                returnValue.Add(new List<int>(lstInputValue));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (inputTag[i] || (i>0 && nums[i] == nums[i-1] && !inputTag[i-1] ))
                {
                    continue;
                }
                inputTag[i] = true;
                lstInputValue.Add(nums[i]);
                InnerMethod(nums, lstInputValue, returnValue, inputTag);
                lstInputValue.RemoveAt(lstInputValue.Count - 1);
                inputTag[i] = false;
            }
        }
    }
}
