using System;
namespace LeetCode
{
	public class insert_into_a_binary_search_tree
	{
		public TreeNode InsertIntoBST(TreeNode root, int val)
		{
            if (root == null)
            {
				return new TreeNode(val);
            }

			var current = root;
            while (current != null)
            {
                if (val < current.val)
                {
                    if (current.left == null)
                    {
                        current.left = new TreeNode(val);
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = new TreeNode(val);
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }

            return root;
		}
	}
}

