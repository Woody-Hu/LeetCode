using System;
namespace LeetCode
{
    public class maximum_binary_tree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTree(nums, 0, nums.Length);
        }

        private TreeNode ConstructMaximumBinaryTree(int[] nums, int left, int right)
        {
            if (left == right)
            {
                return null;
            }

            var max_i = left;
            var maxValue = nums[max_i];
            for (int i = left; i < right; i++)
            {
                var currentValue = nums[i];
                if (currentValue > maxValue)
                {
                    max_i = i;
                    maxValue = currentValue;
                }
            }

            var res = new TreeNode(nums[max_i]);
            res.left = ConstructMaximumBinaryTree(nums, left, max_i);
            res.right = ConstructMaximumBinaryTree(nums, max_i + 1, right);
            return res;
        }
    }
}
