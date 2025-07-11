namespace LeetCode;

public class yuan_quan_zhong_zui_hou_sheng_xia_de_shu_zi_lcof
{
    public int IceBreakingGame(int num, int target)
    {
        var res = 0;
        for (int i = 2; i != num + 1; ++i)
        {
            res = (res + target) % i;
        }

        return res;

    }
}