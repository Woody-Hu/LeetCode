namespace LeetCode;

public class find_the_number_of_winning_players
{
    public int WinningPlayerCount(int n, int[][] pick) {
        var cnts = new int[n][];
        for (var i = 0; i < n; i++)
        {
            cnts[i] = new int[11];
        }

        foreach (var p in pick)
        {
            cnts[p[0]][p[1]]++;
        }
        
        var res = 0;
        for (int i = 0; i < n; i++)
        {
            foreach (var c in cnts[i])
            {
                if (c > i)
                {
                    res++;
                    break;
                }
            }
        }
        
        return res;

    }
}