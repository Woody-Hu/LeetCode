using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class maximize_sum_of_at_most_k_distinct_elements
    {
        public int[] MaxKDistinct(int[] nums, int k)
        {
            ISet<int> numsSet = new HashSet<int>();
            foreach (int num in nums)
            {
                numsSet.Add(num);
            }
            IList<int> numsList = new List<int>(numsSet);
            ((List<int>)numsList).Sort((a, b) => b - a);
            k = Math.Min(k, numsList.Count);
            int[] distinct = new int[k];
            for (int i = 0; i < k; i++)
            {
                distinct[i] = numsList[i];
            }
            return distinct;


        }
    }
}
