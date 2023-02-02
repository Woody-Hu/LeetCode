using System;
namespace LeetCode
{
	public class number_of_good_leaf_nodes_pairs
	{
        public int CountPairs(TreeNode root, int distance)
        {
            var res = DFS(root, distance);
            return res.Item2;
        }

        private (int[], int) DFS(TreeNode root, int distance)
        {
            var depths = new int[distance + 1];
            var isLeaft = root.left == null && root.right == null;
            if (isLeaft)
            {
                depths[0] = 1;
                return (depths, 0);
            }

            var leftDepths = new int[distance + 1];
            var rightDepths = new int[distance + 1];
            var lc = 0;
            var rc = 0;
            if (root.left != null)
            {
                var lr = DFS(root.left, distance);
                leftDepths = lr.Item1;
                lc = lr.Item2;
            }

            if (root.right != null)
            {
                var rr = DFS(root.right, distance);
                rightDepths = rr.Item1;
                rc = rr.Item2;
            }

            for (int i = 0; i < distance; i++)
            {
                depths[i + 1] += leftDepths[i];
                depths[i + 1] += rightDepths[i];
            }

            var res = 0;
            for (int i = 0; i <= distance; i++)
            {
                for (int j = 0; j + i + 2 <= distance; j++)
                {
                    res += leftDepths[i] * rightDepths[j];
                }
            }

            return (depths, res + lc + rc);
        }
    }
}

