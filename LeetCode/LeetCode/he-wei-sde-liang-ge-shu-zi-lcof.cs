namespace LeetCode;

public class he_wei_sde_liang_ge_shu_zi_lcof
{
    public int[] TwoSum(int[] price, int target) {
        var i = 0;
        var j = price.Length - 1;
        while (i < j) {
            var sum = price[i] + price[j];
            if (sum == target) {
                return new int[] {price[i], price[j]};
            } else if (sum < target) {
                i++;
            } else {
                j--;
            }
        }
        
        return new[] {i, j};
    }
}