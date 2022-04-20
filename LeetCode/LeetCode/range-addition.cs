using System;
namespace LeetCode
{
    public class range_addition
    {
        public int[] GetModifiedArray(int length, int[][] updates)
        {
            var diff = new int[length];
            foreach (var item in updates)
            {
                AppendDiff(item[0], item[1], item[2], diff);
            }

            int[] ans = new int[length];
            ans[0] = diff[0];
            for (int i = 1; i < length; i++)
            {
                ans[i] = diff[i] + ans[i - 1];
            }
            return ans;
        }

        private void AppendDiff(int start, int end, int inc, int[] diff)
        {
            diff[start] += inc;
            if (end + 1 < diff.Length)
            {
                diff[end + 1] -= inc;
            }
        }
    }
}
