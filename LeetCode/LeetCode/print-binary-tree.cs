using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class print_binary_tree
    {
        public IList<IList<string>> PrintTree(TreeNode root)
        {
            var height = GetHeight(root);
            var width = (1 << height) - 1;
            var res = new List<IList<string>>();
            for (int i = 0; i < height; i++)
            {
                var temp = new string[width];
                Array.Fill(temp, "");
                res.Add(temp.ToList());
            }

            Fill(res, root, 0, 0, width);
            return res;
        }

        private void Fill(IList<IList<string>> res, TreeNode root, int row, int left, int right)
        {
            if (root == null)
            {
                return;
            }

            var j = (left + right) / 2;
            res[row][j] = root.val.ToString();
            Fill(res, root.left, row + 1, left, j - 1);
            Fill(res, root.right, row + 1, j + 1, right);
        }

        private int GetHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
        }
    }
}
