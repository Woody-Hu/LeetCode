using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CombinationSumIV
    {
        Dictionary<int, int> useDic = new Dictionary<int, int>();

        public int CombinationSum4(int[] nums, int target)
        {
            if (0 == nums.Count())
            {
                return 0;
            }

            int returnValue = 0;

            int numberMax = nums.Max();

            CalculateMethod(nums, target, ref returnValue);

            return returnValue;
        }

        private void CalculateMethod(int[] nums,int target,ref int numbers)
        {
            int backValue = numbers;

            if (useDic.ContainsKey(target))
            {
                numbers = numbers + useDic[target];
                return;
            }

            foreach (var oneValue in nums)
            {
                if (oneValue > target)
                {
                    continue;
                }
                var tempValue = target - oneValue;


                if (0 == tempValue)
                {
                    numbers++;
                    continue;
                }

                CalculateMethod(nums, tempValue, ref numbers);
            }

            useDic.Add(target, numbers - backValue);
        }
    }
}
