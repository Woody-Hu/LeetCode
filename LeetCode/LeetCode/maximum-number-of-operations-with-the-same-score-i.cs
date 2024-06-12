namespace LeetCode;

public class maximum_number_of_operations_with_the_same_score_i
{
    public int MaxOperations(int[] nums)
    {
        var res = 1;
        var preSum = nums[0] + nums[1];
        for (int i = 2; i < nums.Length - 1; i+=2)
        {
            var sum = nums[i] + nums[i + 1];
            if (sum == preSum)
            {
                res++;
            }
            else
            {
                break;
            }
        }
        
        return res;

    }
}