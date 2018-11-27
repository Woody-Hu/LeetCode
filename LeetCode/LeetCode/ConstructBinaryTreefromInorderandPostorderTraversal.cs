using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ConstructBinaryTreefromInorderandPostorderTraversal
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            Dictionary<int, int> inorderValueIndex = new Dictionary<int, int>();

            for (int i = 0; i < inorder.Length; i++)
            {
                inorderValueIndex.Add(inorder[i], i);
            }

            var postIndex = postorder.Length - 1;

            return BuildTree(inorderValueIndex, postorder, ref postIndex, 0, postorder.Length - 1);

        }

        private TreeNode BuildTree(Dictionary<int, int> inorderValueIndex, int[] postorder, ref int postIndex, int start, int end)
        {
            if (start > end || postIndex < 0)
            {
                return null;
            }

            var node = new TreeNode(postorder[postIndex--]);
            ;

            if (start == end)
            {
                return node;
            }

            var nodeIndex = inorderValueIndex[node.val];

            node.right = BuildTree(inorderValueIndex, postorder, ref postIndex, nodeIndex + 1, end);
            node.left = BuildTree(inorderValueIndex, postorder, ref postIndex, start, nodeIndex - 1);
            return node;

        }
    }
}
