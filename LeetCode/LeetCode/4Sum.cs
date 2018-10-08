using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();

            Array.Sort(nums);

            Dictionary<int, int> useDic = new Dictionary<int, int>();

            foreach (var oneValue in nums)
            {
                useDic[oneValue] = useDic.GetValueOrDefault(oneValue)+1;
            }

            IList<int> useValue = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] * 4 > target)
                {
                    break;
                }

                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                useValue.Add(nums[i]);
                useDic[nums[i]]--;
                Find3(nums, returnValue, useValue, useDic, i, target - nums[i]);
                useValue.RemoveAt(useValue.Count - 1);
                useDic[nums[i]]++;

            }

            return returnValue;
        }

        private void Find3(int[] nums, IList<IList<int>> returnValue, IList<int> useValue, Dictionary<int, int> useDic, int useIndex, int target)
        {
            for (int i = useIndex+1; i < nums.Length; i++)
            {
                if (nums[i] * 3 > target)
                {
                    break;
                }

                if (i > useIndex + 1 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                useValue.Add(nums[i]);
                useDic[nums[i]]--;
                Find2(nums, returnValue, useValue, useDic, i, target - nums[i]);
                useValue.RemoveAt(useValue.Count - 1);
                useDic[nums[i]]++;

            }
        }

        private void Find2(int[] nums, IList<IList<int>> returnValue, IList<int> useValue, Dictionary<int, int> useDic,int useIndex,int target)
        {
            for (int i = useIndex + 1; i < nums.Length; i++)
            {
                if (nums[i] * 2 > target)
                {
                    break;
                }

                if (i> useIndex + 1 && nums[i]==nums[i-1])
                {
                    continue;
                }

                useValue.Add(nums[i]);
                useDic[nums[i]]--;
                if (Find(nums,useValue,useDic,target - nums[i]))
                {
                    returnValue.Add(new List<int>(useValue));
                    useValue.RemoveAt(useValue.Count - 1);
                }

                useValue.RemoveAt(useValue.Count - 1);
                useDic[nums[i]]++;

            }
        }

        private bool Find(int[] nums, IList<int> useValue,Dictionary<int, int> useDic, int target)
        {
            if (useDic.ContainsKey(target) && useDic[target] >0 )
            {
                useValue.Add(target);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
