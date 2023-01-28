using System;
namespace LeetCode
{
    public class sort_the_students_by_their_kth_score
    {
        public int[][] SortTheStudents(int[][] score, int k)
        {
            Array.Sort(score, (a, b) => b[k] - a[k]);
            return score;
        }
    }
}
