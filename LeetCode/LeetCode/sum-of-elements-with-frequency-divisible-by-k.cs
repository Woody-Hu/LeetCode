using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class sum_of_elements_with_frequency_divisible_by_k
    {
        public int SumDivisibleByK(int[] nums, int k)
        {
            int sum = 0;
            var frequencyMap = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }
            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value % k == 0)
                {
                    sum += kvp.Key * kvp.Value;
                }
            }

            return sum;

        }
    }
}
