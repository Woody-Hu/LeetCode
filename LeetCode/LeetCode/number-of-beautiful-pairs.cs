namespace LeetCode;

public class number_of_beautiful_pairs
{
    public int CountBeautifulPairs(int[] nums)
    {
        var res = 0;
        var n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            while ( nums[i] >= 10)
            {
                nums[i] /= 10;
            }
            
            for (int j = i+1; j < n; j++)
            {
                if (GCD(nums[i], nums[j] % 10) == 1)
                {
                    res++;
                }
            }
        }

        return res;

    }
    
    private int GCD(int a, int b)
    {
        return b == 0? a : GCD(b, a % b);
    }
}