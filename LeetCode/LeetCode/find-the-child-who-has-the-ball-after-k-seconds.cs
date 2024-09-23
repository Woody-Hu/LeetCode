namespace LeetCode;

public class find_the_child_who_has_the_ball_after_k_seconds
{
    public int NumberOfChild(int n, int k)
    {
        var t = k % (n - 1);
        return (k / (n - 1)) % 2 > 0 ? n - t - 1 : t;

    }
}