using System;
namespace LeetCode
{
    public class construct_binary_tree_from_preorder_and_postorder_traversal
    {
        public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
        {
            return ConstructFromPrePost(preorder, postorder, 0, 0, preorder.Length);
        }

        private TreeNode ConstructFromPrePost(int[] preorder, int[] postorder, int preIndex, int postIndex, int length)
        {
            if (length == 0)
            {
                return null;
            }

            var root = new TreeNode(preorder[preIndex]);
            if (length == 1)
            {
                return root;
            }

            var l = 1;
            for (;  l < length; l++)
            {
                if (postorder[postIndex + l -1] == preorder[preIndex + 1])
                {
                    break;
                }
            }

            root.left = ConstructFromPrePost(preorder, postorder, preIndex + 1, postIndex, l);
            root.right = ConstructFromPrePost(preorder, postorder, preIndex + l + 1, postIndex + l, length - 1 -l);
            return root;
        }
    }
}
