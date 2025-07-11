namespace LeetCode;

public class diao_zheng_shu_zu_shun_xu_shi_qi_shu_wei_yu_ou_shu_qian_mian_lcof
{
    public int[] TrainingPlan(int[] actions)
    {
        var i = 0;
        var j = actions.Length - 1;
        var temp = 0;
        while (i < j)
        {
            while (i < j && (actions[i] & 1) == 1)
            {
                i++;
            }
            
            while (i < j && (actions[j] & 1) == 0)
            {
                j--;
            }
            
            temp = actions[i];
            actions[i] = actions[j];
            actions[j] = temp;
        }
        
        return actions;

    }
}