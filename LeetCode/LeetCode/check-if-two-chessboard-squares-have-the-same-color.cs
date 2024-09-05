namespace LeetCode;

public class check_if_two_chessboard_squares_have_the_same_color
{
    public bool CheckTwoChessboards(string coordinate1, string coordinate2)
    {
        var res1 = (coordinate1[0] + coordinate1[1]) % 2;
        var res2 = (coordinate2[0] + coordinate2[1]) % 2;
        return res1 == res2;

    }
}