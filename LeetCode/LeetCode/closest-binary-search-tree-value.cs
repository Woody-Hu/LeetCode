using System;
namespace LeetCode
{
    public class closest_binary_search_tree_value
    {
        public int ClosestValue(TreeNode root, double target)
        {
            int? leftValue = null;
            int? rightValue = null;
            Visit(root, target, ref leftValue, ref rightValue);
            if (leftValue == null && rightValue == null)
            {
                return -1;
            }
            else if (leftValue == null)
            {
                return rightValue.Value;
            }
            else if (rightValue == null)
            {
                return leftValue.Value;
            }
            else
            {
                if (rightValue.Value - target > target - leftValue.Value)
                {
                    return leftValue.Value;
                }
                else
                {
                    return rightValue.Value;
                }
            }

        }

        private void Visit(TreeNode root, double target, ref int? leftValue, ref int? rightValue)
        {
            if (root == null || (leftValue != null && rightValue != null))
            {
                return;
            }

            Visit(root.left, target, ref leftValue, ref rightValue);
            var value = root.val;
            if (target - value >= 0.0d)
            {
                if (leftValue == null)
                {
                    leftValue = value;
                }
                else
                {
                    leftValue = Math.Max(leftValue.Value, value);
                }
            }
            else
            {
                if (rightValue == null)
                {
                    rightValue = value;
                }
                else
                {
                    rightValue = Math.Min(rightValue.Value, value);
                }
            }

            Visit(root.right, target, ref leftValue, ref rightValue);
        }

        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
