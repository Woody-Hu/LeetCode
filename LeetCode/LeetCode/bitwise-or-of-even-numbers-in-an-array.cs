namespace LeetCode;

public class bitwise_or_of_even_numbers_in_an_array
{
    public int EvenNumberBitwiseORs(int[] nums) {
        int ans = 0;
        foreach (int num in nums) {
            if ((num % 2) == 0) {
                ans |= num;
            }
        }
        return ans;
    }
}