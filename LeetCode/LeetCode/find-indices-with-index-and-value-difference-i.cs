namespace LeetCode;

public class find_indices_with_index_and_value_difference_i
{
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
    {
        var maxIndex = 0;
        var minIndex = 0;
        for (int j = indexDifference; j < nums.Length; j++)
        {
            var i = j - indexDifference;
            if (nums[i] > nums[maxIndex])
            {
                maxIndex = i;
            }
            else if (nums[i] < nums[minIndex])
            {
                minIndex = i;
            }

            if (nums[maxIndex] - nums[j] >= valueDifference)
            {
                return new int[] {maxIndex, j};
            }
            
            if (nums[j] - nums[minIndex] >= valueDifference)
            {
                return new int[] {minIndex, j};
            }
        }
        
        return new int[] {-1, -1};

    }
}