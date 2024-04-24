namespace LeetCode;

public class check_if_it_is_a_good_array
{
    public bool IsGoodArray(int[] nums) {
        var res = nums[0];
        foreach (var num in nums)
        {
            res = Gcd(res, num);
            if (res == 1)
            {
                return true;
            }
        }
        
        return res == 1;
        
    }
    
    private int Gcd(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}