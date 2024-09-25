namespace LeetCode;

public class kLl5u1
{
    public int[] TwoSum(int[] numbers, int target)
    {
        var low = 0;
        var high = numbers.Length - 1;
        while (low < high)
        {
            int sum = numbers[low] + numbers[high];
            if (sum == target) {
                return new []{low, high};
            } 
            else if (sum < target) {
                ++low;
            } else {
                --high;
            }
        }

        return new [] { -1, -1 };

    }
}