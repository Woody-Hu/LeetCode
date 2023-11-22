using System;
namespace LeetCode
{
	public class er_cha_sou_suo_shu_de_di_kda_jie_dian_lcof
	{
        public int FindTargetNode(TreeNode root, int cnt)
        {
            var res = 0;
            FindTargetNode(root, ref cnt, ref res);
            return res;
        }

        private void FindTargetNode(TreeNode root, ref int cnt, ref int res)
        {
            if (root == null)
            {
                return;
            }

            FindTargetNode(root.right, ref cnt, ref res);
            if (cnt == 0)
            {
                return;
            }

            if (--cnt == 0)
            {
                res = root.val;
            }

            FindTargetNode(root.left, ref cnt, ref res);
        }
    }
}

