using System;
namespace LeetCode
{
    public class inorder_successor_in_bst
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var findTarget = false;
            TreeNode res = null;
            Visit(root, p.val, ref findTarget, ref res);
            return res;
        }

        private void Visit(TreeNode root, int target, ref bool findTarget, ref TreeNode res)
        {
            if (root == null || (findTarget && (res != null)))
            {
                return;
            }

            Visit(root.left, target, ref findTarget, ref res);
            if (findTarget && res == null)
            {
                res = root;
            }
            else if (root.val == target)
            {
                findTarget = true;
            }

            Visit(root.right, target, ref findTarget, ref res);
        }
    }
}
