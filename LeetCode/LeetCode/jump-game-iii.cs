using System;
namespace LeetCode
{
    public class jump_game_iii
    {
        public bool CanReach(int[] arr, int start)
        {
            var n = arr.Length;
            var visited = new bool[n];
            return DFS(arr, start, n, visited);
        }

        private bool DFS(int[] num, int idx, int n, bool[] visited)
        {
            if (idx < 0 || idx >= num.Length || visited[idx])
            {
                return false;
            }

            if (num[idx] == 0)
            {
                return true;
            }

            var step = num[idx];
            visited[idx] = true;
            return DFS(num, idx + step, n, visited) || DFS(num, idx - step, n, visited);
        }
    }
}
