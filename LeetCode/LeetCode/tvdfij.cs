using System.Linq;

namespace LeetCode;

public class tvdfij
{
    public int PivotIndex(int[] nums)
    {
        var total = nums.Sum();
        var tempSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (2 * tempSum + nums[i] == total)
            {
                return i;
            }

            tempSum += nums[i];
        }

        return -1;

    }
}