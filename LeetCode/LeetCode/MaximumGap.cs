using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
   public class MaximumGap
    {
        public int MaximumGapMethod(int[] nums)
        {
            if (nums.Length < 2)
            {
                return 0;
            }

            int maxValue = int.MinValue;

            int minValue = int.MaxValue;


            foreach (var oneValue in nums)
            {
                maxValue = Math.Max(maxValue, oneValue);
                minValue = Math.Min(minValue, oneValue);
            }

            if (maxValue == minValue)
                return 0;

            var size = (int)Math.Ceiling((double)(maxValue - minValue) / (nums.Count() - 1));

            int[] intUseMinValues = new int[nums.Count()];

            int[] intUseMaxValues = new int[nums.Count()];

            for (int tempIndex = 0; tempIndex < nums.Count(); tempIndex++)
            {
                intUseMinValues[tempIndex] = int.MaxValue;
                intUseMaxValues[tempIndex] = int.MinValue;
            }


            foreach (var num in nums)
            {
                var index = (num - minValue) / size;
                intUseMinValues[index] = Math.Min(intUseMinValues[index], num);
                intUseMaxValues[index] = Math.Max(intUseMaxValues[index], num);
            }

            int useValue = int.MinValue;

            int preValue = intUseMaxValues[0];

            for (int tempIndex = 1; tempIndex < nums.Count(); tempIndex++)
            {
                if (intUseMinValues[tempIndex] == int.MaxValue || intUseMaxValues[tempIndex] == int.MinValue)
                    continue;
                useValue = Math.Max(useValue, intUseMinValues[tempIndex] - preValue);
                preValue = intUseMaxValues[tempIndex];
            }

            return useValue;
        }
    }
}
