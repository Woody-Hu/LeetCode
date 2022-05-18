using System;
namespace LeetCode
{
    public class check_if_a_string_is_a_valid_sequence_from_root_to_leaves_path_in_a_binary_tree
    {
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            return Visit(root, arr, 0);
        }

        private bool Visit(TreeNode root, int[] arr, int index)
        {
            if (root == null || root.val != arr[index])
            {
                return false;
            }

            if (index == arr.Length - 1)
            {
                if (root.left == null && root.right == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return Visit(root.left, arr, index + 1) || Visit(root.right, arr, index + 1);
        }
    }
}
