namespace LeetCode;

public class minimum_operations_to_make_binary_array_elements_equal_to_one_i
{
    public int MinOperations(int[] nums) {
        var n = nums.Length;
        var res = 0;
        for (int i = 0; i < n - 2; i++)
        {
            if (nums[i] == 0)
            {
                nums[i + 1] ^= 1;
                nums[i + 2] ^= 1;
                res++;
            }
        }
        
        return nums[n - 2]!= 0 && nums[n - 1] != 0 ? res :-1;

    }
}