namespace LeetCode;

public class average_value_of_even_numbers_that_are_divisible_by_three
{
    public int AverageValue(int[] nums)
    {
        var sum = 0;
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var c = nums[i];
            if (c % 6 ==0)
            {
                sum += c;
                count++;
            }
        }

        return count > 0 ? sum / count : 0;


    }
}