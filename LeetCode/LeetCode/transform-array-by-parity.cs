namespace LeetCode;

public class transform_array_by_parity
{
    public int[] TransformArray(int[] nums)
    {
        var count1 = 0;
        foreach (var num in nums)
        {
            count1 += num % 2;
        }
        
        var n = nums.Length;
        var count0 = n - count1;
        var result = new int[n];
        for (var i = 0; i < count0; i++)
        {
            result[i] = 0;
        }
        
        for (var i = count0; i < n; i++)
        {
            result[i] = 1;
        }

        return result;
    }
}