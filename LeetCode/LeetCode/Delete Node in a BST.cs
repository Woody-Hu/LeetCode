using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Delete_Node_in_a_BST
    {
        private bool IsLeaf(TreeNode root)
        {
            return root.left == null && root.right == null;
        }

        private TreeNode GetMax(TreeNode root)
        {
            TreeNode current = root;
            while (current.right != null) current = current.right;
            return current;
        }

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return root;
            if (root.val > key) root.left = DeleteNode(root.left, key);
            else if (root.val < key) root.right = DeleteNode(root.right, key);
            else
            {
                if (IsLeaf(root)) root = null;
                else if (root.left == null) root = root.right;
                else if (root.right == null) root = root.left;
                else
                {
                    TreeNode temp = GetMax(root.left);
                    root.val = temp.val;
                    root.left = DeleteNode(root.left, temp.val);
                }
            }

            return root;
        }
    }
}
