namespace LeetCode;

public class smallest_index_with_digit_sum_equal_to_index
{
    public int SmallestIndex(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            int s = 0;
            for (int x = nums[i]; x > 0; x /= 10) {
                s += x % 10;
            }
            if (s == i) {
                return i;
            }
        }
        return -1;
    }
}