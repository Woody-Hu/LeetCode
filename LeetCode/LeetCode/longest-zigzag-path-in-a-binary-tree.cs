using System;
namespace LeetCode
{
	public class longest_zigzag_path_in_a_binary_tree
	{
        public int LongestZigZag(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var res = 0;
            LongestZigZagInternal(root, true, 0, ref res);
            LongestZigZagInternal(root, false, 0, ref res);
            return res;
        }

        private void LongestZigZagInternal(TreeNode root, bool toLeft, int length, ref int res)
        {
            res = Math.Max(length, res);
            if (!toLeft)
            {
                if (root.left != null)
                {
                    LongestZigZagInternal(root.left, true, length + 1, ref res);
                }

                if (root.right != null)
                {
                    LongestZigZagInternal(root.right, false, 1, ref res);
                }
            }
            else
            {
                if (root.right != null)
                {
                    LongestZigZagInternal(root.right, false, length + 1, ref res);
                }

                if (root.left != null)
                {
                    LongestZigZagInternal(root.left, true, 1, ref res);
                }
            }
        }
    }
}

