using System;
namespace LeetCode
{
	public class er_cha_shu_de_jing_xiang_lcof
	{
        public TreeNode MirrorTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            var temp = root.left;
            root.left = MirrorTree(root.right);
            root.right = MirrorTree(temp);
            return root;
        }
    }
}

