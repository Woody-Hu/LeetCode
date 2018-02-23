using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<int> returnValues = new List<int>();
            bool resutlTag = false;
            for (int i = 0; i < nums.Length; i++)
            {
                resutlTag = false;

                for (int k = i + 1; k < nums.Length; k++)
                {

                    if (target == (nums[i] + nums[k]))
                    {
                        returnValues.Add(i);
                        returnValues.Add(k);
                        resutlTag = true;
                        break;
                    }
                }
                if (true == resutlTag)
                {
                    break;
                }
            }
            return returnValues.ToArray();
        }
    }
}
