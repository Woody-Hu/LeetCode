using System;
namespace LeetCode
{
    public class largest_bst_subtree
    {
        public int LargestBSTSubtree(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var res = 0;
            Visist(root, ref res);
            return res;
        }

        private TreeRecord Visist(TreeNode root, ref int maxCount)
        {
            var res = new TreeRecord() { NodeCount = 1, LeftValue = root.val, RightValue = root.val, IsBST = true };
            if (root.left == null && root.right == null)
            {
                maxCount = Math.Max(maxCount, 1);
                return res;
            }

            if (root.left != null)
            {
                var leftRes = Visist(root.left, ref maxCount);
                if (leftRes.IsBST && leftRes.RightValue < root.val)
                {
                    res.NodeCount += leftRes.NodeCount;
                    res.LeftValue = leftRes.LeftValue;
                }
                else
                {
                    res.IsBST = false;
                }
            }

            if (root.right != null)
            {
                var rightRes = Visist(root.right, ref maxCount);
                if (rightRes.IsBST && rightRes.LeftValue > root.val)
                {
                    res.NodeCount += rightRes.NodeCount;
                    res.RightValue = rightRes.RightValue;
                }
                else
                {
                    res.IsBST = false;
                }
            }

            if (res.IsBST)
            {
                maxCount = Math.Max(maxCount, res.NodeCount);
            }

            return res;
        }

        private class TreeRecord
        {
            internal int NodeCount { get; set;}

            internal int LeftValue { get; set; }

            internal int RightValue { get; set; }

            internal bool IsBST { get; set; }
        }
    }
}
