using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestHarmoniousSubsequence
    {
        public int FindLHS(int[] nums)
        {


            var groupedValue = nums.GroupBy(k => k).ToDictionary(k=>k.Key,k=>k.Count());

            int returnValue = int.MinValue;

            foreach (var OneKVP in groupedValue)
            {
                if (groupedValue.ContainsKey(OneKVP.Key + 1))
                {
                    returnValue = Math.Max(OneKVP.Value + groupedValue[OneKVP.Key + 1], returnValue);
                }
            }


            returnValue = returnValue == int.MinValue ? 0 : returnValue;


            return returnValue;
        }
    }
}
