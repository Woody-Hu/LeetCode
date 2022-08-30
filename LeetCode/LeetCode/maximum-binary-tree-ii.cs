using System;
namespace LeetCode
{
    public class maximum_binary_tree_ii
    {
        public TreeNode InsertIntoMaxTree(TreeNode root, int val)
        {
            TreeNode parent = null;
            var current = root;
            while (current !=  null)
            {
                if (val > current.val)
                {
                    if (parent == null)
                    {
                        return new TreeNode(val, root, null);
                    }

                    var node = new TreeNode(val, current, null);
                    parent.right = node;
                    return root;
                }
                else
                {
                    parent = current;
                    current = current.right;
                }
            }

            parent.right = new TreeNode(val);
            return root;
        }
    }
}
