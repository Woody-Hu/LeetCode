using System;
namespace LeetCode
{
    public class maximum_number_of_groups_entering_a_competition
    {
        public int MaximumGroups(int[] grades)
        {
            var n = grades.Length;
            return (int)((Math.Sqrt(8 * n + 1) - 1) / 2);
        }
    }
}
