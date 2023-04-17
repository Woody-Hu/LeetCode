using System;
namespace LeetCode
{
	public class LwUNpT
	{
        public int FindBottomLeftValue(TreeNode root)
        {
            var maxHeight = 0;
            var res = 0;
            DFS(root, 0, ref maxHeight, ref res);
            return res;
        }

        private void DFS(TreeNode root, int height, ref int maxHeight, ref int res)
        {
            if (root == null)
            {
                return;
            }

            height++;
            DFS(root.left, height, ref maxHeight, ref res);
            DFS(root.right, height, ref maxHeight, ref res);
            if (height> maxHeight)
            {
                maxHeight = height;
                res = root.val;
            }
        }
    }
}

