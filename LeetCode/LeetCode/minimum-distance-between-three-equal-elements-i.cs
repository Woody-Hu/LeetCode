using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class minimum_distance_between_three_equal_elements_i
    {
        public int MinimumDistance(int[] nums)
        {
            int minDistance = int.MaxValue;
            IDictionary<int, IList<int>> numToIndices = new Dictionary<int, IList<int>>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                numToIndices.TryAdd(nums[i], new List<int>());
                numToIndices[nums[i]].Add(i);
            }
            foreach (KeyValuePair<int, IList<int>> pair in numToIndices)
            {
                IList<int> indices = pair.Value;
                int size = indices.Count;
                for (int i = 2; i < size; i++)
                {
                    int distance = (indices[i] - indices[i - 2]) * 2;
                    minDistance = Math.Min(minDistance, distance);
                }
            }
            return minDistance != int.MaxValue ? minDistance : -1;
        }
    }
}
