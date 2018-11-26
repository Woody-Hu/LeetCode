using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        private int preIndex = 0;
        private int inIndex = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return dfs(preorder, inorder, null);
        }

        public TreeNode dfs(int[] preorder, int[] inorder, TreeNode end)
        {
            if (inIndex > inorder.Length - 1 || (end != null && end.val == inorder[inIndex]))
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[preIndex++]);
            root.left = dfs(preorder, inorder, root);

            inIndex++;
            root.right = dfs(preorder, inorder, end);

            return root;
        }
    }
}
