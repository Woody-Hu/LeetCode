namespace LeetCode;

public class count_pairs_that_form_a_complete_day_ii
{
    public long CountCompleteDayPairs(int[] hours)
    {
        var res = 0;
        var cnt = new int[24];
        foreach (var c in hours)
        {
            res += cnt[(24-c % 24) % 24];
            cnt[c % 24]++;
        }
        
        return res;

    }
}