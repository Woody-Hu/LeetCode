using System;
namespace LeetCode
{
    public class find_center_of_star_graph
    {
        public int FindCenter(int[][] edges)
        {
            return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];
        }
    }
}
