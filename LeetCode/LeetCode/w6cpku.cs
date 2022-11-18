using System;
namespace LeetCode
{
    public class w6cpku
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            var sum = 0;
            return ConvertBST(root, ref sum);
        }

        private TreeNode ConvertBST(TreeNode root, ref int sum)
        {
            if (root != null)
            {
                ConvertBST(root.right, ref sum);
                sum += root.val;
                root.val = sum;
                ConvertBST(root.left, ref sum);
            }

            return root;
        }
    }
}
