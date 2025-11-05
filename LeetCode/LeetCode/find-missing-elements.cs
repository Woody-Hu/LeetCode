using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class find_missing_elements
    {
        public IList<int> FindMissingElements(int[] nums)
        {
            int minNum = int.MaxValue, maxNum = int.MinValue;
            ISet<int> numsSet = new HashSet<int>();
            foreach (int num in nums)
            {
                minNum = Math.Min(minNum, num);
                maxNum = Math.Max(maxNum, num);
                numsSet.Add(num);
            }
            IList<int> missing = new List<int>();
            for (int i = minNum + 1; i < maxNum; i++)
            {
                if (!numsSet.Contains(i))
                {
                    missing.Add(i);
                }
            }
            return missing;
        }
    }
}
