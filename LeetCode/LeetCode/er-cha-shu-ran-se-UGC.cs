using System;
namespace LeetCode
{
	public class er_cha_shu_ran_se_UGC
	{
        public int MaxValue(TreeNode root, int k)
        {
            var dp = Calculate(root, k);
            var res = int.MinValue;
            foreach (var item in dp)
            {
                res = Math.Max(res, item);
            }

            return res;
        }

        private int[] Calculate(TreeNode root, int k)
        {
            var dp = new int[k + 1];
            if (root == null)
            {
                return dp;
            }

            var l = Calculate(root.left, k);
            var r = Calculate(root.right, k);
            var maxL = int.MinValue;
            var maxR = int.MinValue;
            for (int i = 0; i <= k; i++)
            {
                maxL = Math.Max(maxL, l[i]);
                maxR = Math.Max(maxR, r[i]);
            }

            dp[0] = maxL + maxR;
            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] = Math.Max(dp[i], root.val + l[j] + r[i - 1 - j]);
                }
            }

            return dp;
        }
    }
}

