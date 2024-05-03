using System.Collections.Generic;

namespace LeetCode;

public class last_visited_integers
{
    public IList<int> LastVisitedIntegers(int[] nums)
    {
        var res = new List<int>();
        var arr = new List<int>();
        var k = 0;
        var size = 0;
        foreach (var num in nums)
        {
            if (num == -1)
            {
                k++;
                if (k <= size)
                {
                    res.Add(arr[size - k]);
                }
                else
                {
                    res.Add(-1);
                }
            }
            else
            {
                arr.Add(num);
                size++;
                k = 0;
            }
        }
        
        return res;
    }
}