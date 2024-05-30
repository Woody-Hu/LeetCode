namespace LeetCode;

public class find_the_xor_of_numbers_which_appear_twice
{
    public int DuplicateNumbersXOR(int[] nums)
    {
        var res = 0;
        var mask = 0l;
        foreach (var num in nums)
        {
            if ((mask >> num & 1) > 0)
            {
                res ^= num;
            }
            else
            {
                mask |= 1L << num;
            }
        }

        return res;
    }
}