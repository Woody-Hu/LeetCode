namespace LeetCode;

public class sum_of_good_numbers
{
    public int SumOfGoodNumbers(int[] nums, int k) {
        var n = nums.Length;
        var res = 0;
        for (int i = 0; i < n; i++)
        {
            var x = nums[i];
            if ((i < k || x > nums[i - k]) && (i + k >= n || x > nums[i + k])) {
                res += x;
            }
        }
        
        return res;
    }
}