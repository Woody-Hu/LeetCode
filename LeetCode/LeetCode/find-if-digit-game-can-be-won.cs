namespace LeetCode;

public class find_if_digit_game_can_be_won
{
    public bool CanAliceWin(int[] nums)
    {
        var s = 0;
        foreach (var item in nums)
        {
            s += item < 10? item: -item;
        }

        return s != 0;

    }
}