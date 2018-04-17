using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RelativeRanks
    {
        public string[] FindRelativeRanks(int[] nums)
        {
            string[] returnValues = new string[nums.Length];

            Dictionary<int, int> useDic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                useDic.Add(nums[i], i);
            }

            var useValues = nums.OrderBy(k => -k).ToList();

            for (int i = 0; i < useValues.Count; i++)
            {
                if (i == 0)
                {
                    returnValues[useDic[useValues[i]]] = "Gold Medal";
                }
                else if (i == 1)
                {
                    returnValues[useDic[useValues[i]]] = "Silver Medal";
                }
                else if (i == 2)
                {
                    returnValues[useDic[useValues[i]]] = "Bronze Medal";
                }
                else
                {
                    returnValues[useDic[useValues[i]]] = (i + 1).ToString();
                }
            }

            return returnValues;


        }
    }
}
