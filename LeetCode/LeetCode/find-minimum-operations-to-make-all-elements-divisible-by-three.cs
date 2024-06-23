namespace LeetCode;

public class find_minimum_operations_to_make_all_elements_divisible_by_three
{
    public int MinimumOperations(int[] nums) {
        var res = 0;
        foreach (var item in nums)
        {
            res += item % 3 != 0? 1:0;
        }

        return res;
    }
}