using System.Linq;

namespace LeetCode;

public class find_the_integer_added_to_array_i
{
    public int AddedInteger(int[] nums1, int[] nums2) {
        var n = nums1.Length;
        var sum1 = nums1.Sum();
        var sum2 = nums2.Sum();
        var diff = sum2 - sum1;
        var res = diff / n;
        return res;

    }
}