using System;
namespace LeetCode
{
    public class maximum_score_from_removing_stones
    {
        public int MaximumScore(int a, int b, int c)
        {
            var array = new int[] { a, b, c };
            Array.Sort(array);
            if (array[0] + array[1] <= array[2])
            {
                return array[0] + array[1];
            }
            else
            {
                return (array[0] + array[1] + array[2]) / 2;
            }
        }
    }
}
