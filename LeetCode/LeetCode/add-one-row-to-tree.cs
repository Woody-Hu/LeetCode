using System;
namespace LeetCode
{
    public class add_one_row_to_tree
    {
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                var res = new TreeNode(val);
                res.left = root;
                return res;
            }

            Visit(root, val, 1, depth);
            return root;
        }

        private void Visit(TreeNode root, int val, int currentDepth, int target)
        {
            if (root == null)
            {
                return;
            }

            if (currentDepth == target - 1)
            {
                var left = root.left;
                var right = root.right;
                var newLeft = new TreeNode(val);
                newLeft.left = left;
                var newRight = new TreeNode(val);
                newRight.right = right;
                root.left = newLeft;
                root.right = newRight;
            }
            else
            {
                Visit(root.left, val, currentDepth + 1, target);
                Visit(root.right, val, currentDepth + 1, target);
            }
        }
    }
}
