namespace LeetCode;

public class minimum_operations_to_make_binary_array_elements_equal_to_one_ii
{
    public int MinOperations(int[] nums)
    {
        var res = 0;
        foreach (var item in nums)
        {
            if (item == res % 2)
            {
                res++;
            }
        }

        return res;
    }
}