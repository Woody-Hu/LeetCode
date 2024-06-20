namespace LeetCode;

public class crawler_log_folder
{
    public int MinOperations(string[] logs)
    {
        var res = 0;
        foreach (var log in logs)
        {
            if ("./".Equals(log))
            {
                continue;
            }
            else if ("../".Equals(log))
            {
                if (res > 0)
                {
                    res--;
                }
            }
            else
            {
                res++;
            }
        }
        
        return res;

    }
}