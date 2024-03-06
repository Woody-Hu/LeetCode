namespace LeetCode;

public class find_the_k_or_of_an_array
{
    public int FindKOr(int[] nums, int k)
    {
        var res = 0;
        for (int i = 0; i < 31; i++)
        {
            var count = 0;
            foreach (var num in nums)
            {
                if ((num & (1 << i)) != 0)
                {
                    count++;
                }
            }
            if (count >= k)
            {
                res |= (1 << i);
            }
        }
        
        return res;
    }
    
}