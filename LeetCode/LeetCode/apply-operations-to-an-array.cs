namespace LeetCode;

public class apply_operations_to_an_array
{
    public int[] ApplyOperations(int[] nums)
    {
        var n = nums.Length;
        for (int i = 0, j = 0; i < n; i++)
        {
            if (i + 1 < n && nums[i] == nums[i + 1]) {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
            if (nums[i] != 0) {
                Swap(nums, i, j);
                j++;
            }
        }

        return nums;
    }
    
    private void Swap(int[] nums, int i, int j)
    {
        (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}