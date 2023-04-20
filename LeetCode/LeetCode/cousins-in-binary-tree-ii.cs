using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class cousins_in_binary_tree_ii
	{
        public TreeNode ReplaceValueInTree(TreeNode root)
        {
            root.val = 0;
            var queue = new List<TreeNode>();
            queue.Add(root);
            while (queue.Any())
            {
                var temp = queue;
                queue = new List<TreeNode>();
                var nextSum = 0;
                foreach (var item in temp)
                {
                    if (item.left != null)
                    {
                        queue.Add(item.left);
                        nextSum += item.left.val;
                    }

                    if (item.right != null)
                    {
                        queue.Add(item.right);
                        nextSum += item.right.val;
                    }
                }

                foreach (var item in temp)
                {
                    var childSum = (item.left == null ? 0 : item.left.val) + (item.right == null ? 0 : item.right.val);
                    if (item.left != null)
                    {
                        item.left.val = nextSum - childSum;
                    }

                    if (item.right != null)
                    {
                        item.right.val = nextSum - childSum;
                    }
                }
            }

            return root;
        }
    }
}

