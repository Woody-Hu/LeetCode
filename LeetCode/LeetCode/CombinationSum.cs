using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class CombinationSum
    {
        public IList<IList<int>> CombinationSumMethod(int[] candidates, int target)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();

            InnerMethod(candidates, new List<int>(), target, ref returnValue);

            return returnValue;
        }

        private void InnerMethod(int[] candidates,List<int> inputValue, int target,ref IList<IList<int>> returnValue)
        {
            if (target < 0)
            {
                return;
            }
            else if (0 == target)
            {
                var addedRange = new List<int>();
                addedRange.AddRange(inputValue);
                returnValue.Add(addedRange);
            }
            else
            {
                foreach (var oneValue in candidates)
                {
                    if (inputValue.Count > 0)
                    {
                        var tempValue = inputValue[inputValue.Count - 1];
                        if (tempValue > oneValue)
                        {
                            continue;
                        }
                    }

                    inputValue.Add(oneValue);
                    InnerMethod(candidates, inputValue, target - oneValue, ref returnValue);
                    inputValue.RemoveAt(inputValue.Count - 1);
                }

            }

        }
    }
}
