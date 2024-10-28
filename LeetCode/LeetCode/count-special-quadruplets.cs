namespace LeetCode;

public class count_special_quadruplets
{
    public int CountQuadruplets(int[] nums) {
        var n = nums.Length;
        var res = 0;
        for (int a = 0; a < n; a++)
        {
            for (int b = a + 1; b < n; ++b) {
                for (int c = b + 1; c < n; ++c) {
                    for (int d = c + 1; d < n; ++d) {
                        if (nums[a] + nums[b] + nums[c] == nums[d]) {
                            ++res;
                        }
                    }
                }
            }
        }

        return res;

    }
}