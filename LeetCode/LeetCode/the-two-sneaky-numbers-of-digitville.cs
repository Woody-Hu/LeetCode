using System.Collections.Generic;

namespace LeetCode;

public class the_two_sneaky_numbers_of_digitville
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        var res = new List<int>();
        var set = new HashSet<int>();
        foreach (var item in nums)
        {
            if (set.Contains(item))
            {
                res.Add(item);
            }
            
            set.Add(item);
        }
        
        return res.ToArray();

    }
}