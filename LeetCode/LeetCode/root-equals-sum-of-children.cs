using System;
namespace LeetCode
{
    public class root_equals_sum_of_children
    {
        public bool CheckTree(TreeNode root)
        {
            return root.val == root.left.val + root.right.val;
        }
    }
}
