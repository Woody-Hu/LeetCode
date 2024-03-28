namespace LeetCode;

public class chalkboard_xor_game
{
    public bool XorGame(int[] nums) {
        if (nums.Length %2 == 0)
        {
            return true;
        }
        
        var xor = 0;
        foreach (var num in nums)
        {
            xor ^= num;
        }
        
        return xor == 0;
    }
}