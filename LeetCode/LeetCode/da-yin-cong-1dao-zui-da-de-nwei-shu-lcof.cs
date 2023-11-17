using System;
namespace LeetCode
{
	public class da_yin_cong_1dao_zui_da_de_nwei_shu_lcof
	{
        public int[] CountNumbers(int cnt)
        {
            var end = (int)Math.Pow(10, cnt) - 1;
            var res = new int[end];
            for (int i = 0; i < end; i++)
            {
                res[i] = i + 1;
            }

            return res;
        }
    }
}

