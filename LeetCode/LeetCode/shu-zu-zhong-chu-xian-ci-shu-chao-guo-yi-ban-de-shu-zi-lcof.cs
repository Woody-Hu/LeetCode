namespace LeetCode;

public class shu_zu_zhong_chu_xian_ci_shu_chao_guo_yi_ban_de_shu_zi_lcof
{
    public int InventoryManagement(int[] stock)
    {
        var x = 0;
        var votes = 0;
        foreach (var num in stock)
        {
            if (votes == 0)
            {
                x = num;
            }

            votes += num == x ? 1 : -1;
        }
        
        return x;

    }
}