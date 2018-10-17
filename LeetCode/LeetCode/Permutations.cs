using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> returnValue = new List<IList<int>>();
            HashSet<int> useSet = new HashSet<int>();

            PreParePermute(returnValue,useSet,nums);

            return returnValue;
        }

        private void PreParePermute(IList<IList<int>> rList, HashSet<int> uSet, int[] nums)
        {
            if (nums.Length == uSet.Count)
            {
                rList.Add(new List<int>(uSet));
            }

            foreach (var oneNum in nums)
            {
                if (uSet.Contains(oneNum))
                {
                    continue;
                }

                uSet.Add(oneNum);
                PreParePermute(rList,uSet,nums);
                uSet.Remove(oneNum);
            }
        }
    }
}
