using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CombinationSumII
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();

            Array.Sort(candidates);

            List<int> useLst = new List<int>();

            GetCombination(candidates, target, 0, useLst, returnValue);

            return returnValue;
        }

        private void GetCombination(int[] candidates,int target,int useIndex,List<int> useLst, IList<IList<int>> returnValue)
        {
            for (int i = useIndex; i < candidates.Length; i++)
            {
                if (i>useIndex && candidates[i] == candidates[i-1])
                {
                    continue;
                }

                if (candidates[i] > target)
                {
                    break;
                }

                if (target == candidates[i])
                {
                    useLst.Add(candidates[i]);
                    returnValue.Add(new List<int>(useLst));
                    useLst.RemoveAt(useLst.Count - 1);
                    break;
                }

                useLst.Add(candidates[i]);

                GetCombination(candidates, target - candidates[i], i + 1, useLst, returnValue);
                useLst.RemoveAt(useLst.Count - 1);


            }
        }
    }
}
