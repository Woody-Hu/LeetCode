using System;
namespace LeetCode
{
	public class find_a_corresponding_node_of_a_binary_tree_in_a_clone_of_that_tree
	{
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == target)
            {
                return cloned;
            }

            TreeNode res = null;
            if (original.left != null)
            {
                res = GetTargetCopy(original.left, cloned.left, target);
            }

            if (res == null && original.right != null)
            {
                res = GetTargetCopy(original.right, cloned.right, target);
            }

            return res;
        }
    }
}

