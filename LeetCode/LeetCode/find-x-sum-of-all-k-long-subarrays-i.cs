using System;
using System.Collections.Generic;

namespace LeetCode;

public class find_x_sum_of_all_k_long_subarrays_i
{
    public int[] FindXSum(int[] nums, int k, int x) {
        int n = nums.Length;
        int[] answer = new int[n - k + 1];
        for (int i = 0; i < n - k + 1; i++) {
            IDictionary<int, int> counts = new Dictionary<int, int>();
            for (int j = 0; j < k; j++) {
                int num = nums[i + j];
                counts.TryAdd(num, 0);
                counts[num]++;
            }
            IList<int[]> numsCounts = new List<int[]>();
            foreach (KeyValuePair<int, int> pair in counts) {
                numsCounts.Add(new int[]{pair.Key, pair.Value});
            }
            ((List<int[]>) numsCounts).Sort((a, b) => a[1] != b[1] ? b[1] - a[1] : b[0] - a[0]);
            int sum = 0;
            int maxCount = Math.Min(x, numsCounts.Count);
            for (int j = 0; j < maxCount; j++) {
                int[] numCount = numsCounts[j];
                sum += numCount[0] * numCount[1];
            }
            answer[i] = sum;
        }
        return answer;
    }
}