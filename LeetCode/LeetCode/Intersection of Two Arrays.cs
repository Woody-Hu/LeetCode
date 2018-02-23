using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public partial class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> returnValue = new List<int>();

            foreach (var tempValue1 in nums1)
            {
                foreach (var tempValue2 in nums2)
                {
                    if (tempValue1 == tempValue2)
                    {
                        if (!returnValue.Contains(tempValue1))
                        {
                            returnValue.Add(tempValue1);
                        }
                    }
                }
            }

            return returnValue.ToArray();
        }
    }
}
