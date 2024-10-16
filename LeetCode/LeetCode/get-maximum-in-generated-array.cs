using System.Linq;

namespace LeetCode;

public class get_maximum_in_generated_array
{
    public int GetMaximumGenerated(int n) {
        if (n == 0) 
            return 0;
        
        var nums = new int[n + 1];
        nums[1] = 1;
        
        for (int i = 2; i <= n; ++i) {
            nums[i] = nums[i / 2] + i % 2 * nums[i / 2 + 1];
        }
        
        return nums.Max();
    }
}