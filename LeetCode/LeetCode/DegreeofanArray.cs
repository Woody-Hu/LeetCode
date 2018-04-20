using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class DegreeofanArray
    {
        public int FindShortestSubArray(int[] nums)
        {
            if (0 == nums.Length)
            {
                return 0;
            }

            Dictionary<int, int[]> useDic = new Dictionary<int, int[]>();

            int tempIndex =0;
            foreach (var oneValue in nums)
            {
                if (!useDic.ContainsKey(oneValue))
                {
                    useDic.Add(oneValue, new int[] { 1, tempIndex, tempIndex });
                }
                else
                {
                    useDic[oneValue][0]++;
                    useDic[oneValue][2] = tempIndex;
                }

                tempIndex++;
            }

            var orderDic = useDic.OrderBy(k => -k.Value[0]);

            var selectDic = from n in orderDic where n.Value[0] == orderDic.ElementAt(0).Value[0] select n;

            int returnValue = int.MaxValue;

            foreach (var oneGroup in selectDic)
            {
                returnValue = Math.Min(returnValue, oneGroup.Value[2] - oneGroup.Value[1] + 1);
            }

            return returnValue;

        }
    }
}
