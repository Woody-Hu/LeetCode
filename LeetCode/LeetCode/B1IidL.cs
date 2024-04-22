namespace LeetCode;

public class B1IidL
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        var res = 0;
        var left = 0;
        var right = arr.Length - 2;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (arr[mid] > arr[mid + 1])
            {
                res = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return res;
    }
}