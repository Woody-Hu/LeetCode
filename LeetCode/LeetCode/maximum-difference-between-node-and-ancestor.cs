using System;
namespace LeetCode
{
    public class maximum_difference_between_node_and_ancestor
    {
        public int MaxAncestorDiff(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var res = 0;
            DFS(root, -1, int.MaxValue, ref res);
            return res;
        }

        private void DFS(TreeNode node, int max, int min, ref int res)
        {
            if (node == null) return;
            if (node.val > max) max = node.val;
            if (node.val < min) min = node.val;
            DFS(node.left, max, min, ref res);
            DFS(node.right, max, min, ref res);
            res = Math.Max(res, Math.Max((max - node.val), (node.val - min)));
        }
    }
}
