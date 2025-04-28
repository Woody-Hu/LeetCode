namespace LeetCode;

public class count_subarrays_of_length_three_with_a_condition
{
    public int CountSubarrays(int[] nums) {
        int n = nums.Length;
        int ans = 0;
        for (int i = 1; i < n - 1; ++i) {
            if (nums[i] == (nums[i - 1] + nums[i + 1]) * 2) {
                ++ans;
            }
        }
        return ans;
    }
}