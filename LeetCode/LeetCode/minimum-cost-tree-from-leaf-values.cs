using System;
namespace LeetCode
{
    public class minimum_cost_tree_from_leaf_values
    {
        public int MctFromLeafValues(int[] arr)
        {
            int[,] dp = new int[arr.Length, arr.Length];
            int min = 0;
            for (int le = 1; le <= arr.Length; le++)
            {
                for (int left = 0; left + le < arr.Length; left++)
                {
                    int right = left + le;
                    min = int.MaxValue;
                    for (int k = left; k < right; k++)
                    {
                        min = Math.Min(min, dp[left, k] + dp[k + 1, right] + this.RangeMaxEle(left, k, arr) * this.RangeMaxEle(k + 1, right, arr));
                    }
                    dp[left, right] = min;
                }
            }

            return dp[0, arr.Length - 1];
        }

        private int RangeMaxEle(int left, int right, int[] arr)
        {
            int tem = 0;
            while (left <= right)
            {
                tem = Math.Max(tem, arr[left++]);
            }
            return tem;
        }
    }
}
