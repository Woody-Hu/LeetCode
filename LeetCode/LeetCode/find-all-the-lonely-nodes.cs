using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_all_the_lonely_nodes
    {
        public IList<int> GetLonelyNodes(TreeNode root)
        {
            var res = new List<int>();
            Visit(root, res);
            return res;
        }

        private void Visit(TreeNode root, IList<int> res)
        {
            if (root == null)
            {
                return;
            }

            if (root.left != null && root.right == null)
            {
                res.Add(root.left.val);
            }
            else if (root.right != null && root.left == null)
            {
                res.Add(root.right.val);
            }

            Visit(root.left, res);
            Visit(root.right, res);
        }
    }
}
