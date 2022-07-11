using System;
namespace LeetCode
{
    public class evaluate_boolean_binary_tree
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.val <= 1)
            {
                return root.val == 1;
            }

            if (root.val == 2)
            {
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            }

            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }
    }
}
