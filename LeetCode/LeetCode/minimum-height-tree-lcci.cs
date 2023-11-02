using System;
namespace LeetCode
{
	public class minimum_height_tree_lcci
	{
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBSTInternal(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBSTInternal(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            var mid = (left + right) / 2;

            var root = new TreeNode(nums[mid]);
            root.left = SortedArrayToBSTInternal(nums, left, mid - 1);
            root.right = SortedArrayToBSTInternal(nums, mid + 1, right);
            return root;
        }
    }
}

