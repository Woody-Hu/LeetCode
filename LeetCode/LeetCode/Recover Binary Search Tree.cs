using System;
namespace LeetCode
{
    public class Recover_Binary_Search_Tree
    {
        TreeNode prev = null;
        TreeNode first = null;
        TreeNode second = null;
        public Recover_Binary_Search_Tree()
        {
        }

        public void RecoverTree(TreeNode root)
        {
            Helper(root);
            Swap(first, second);
        }

        void Swap(TreeNode a, TreeNode b)
        {
            int temp = a.val;
            a.val = b.val;
            b.val = temp;
        }

        void Helper(TreeNode root)
        {
            if (root == null)
                return;
            Helper(root.left);

            if (prev != null && prev.val > root.val)
            {
                if (first == null)
                {
                    first = prev;
                }
                second = root;
            }

            prev = root;
            Helper(root.right);
        }
    }
}
