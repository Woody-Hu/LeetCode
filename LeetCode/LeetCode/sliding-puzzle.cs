using System.Collections.Generic;
using System.Text;

namespace LeetCode;

public class sliding_puzzle
{
    int[][] neighbors = new int[6][]{new[]{1, 3}, new[]{0, 2, 4}, new[]{1, 5}, new[]{0, 4}, new[]{1, 3, 5}, new[]{2, 4}};

    public int SlidingPuzzle(int[][] board) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 2; ++i) {
            for (int j = 0; j < 3; ++j) {
                sb.Append(board[i][j]);
            }
        }
        string initial = sb.ToString();
        if ("123450".Equals(initial)) {
            return 0;
        }

        int step = 0;
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(initial);
        ISet<string> seen = new HashSet<string>();
        seen.Add(initial);

        while (queue.Count > 0) {
            ++step;
            int size = queue.Count;
            for (int i = 0; i < size; ++i) {
                string status = queue.Dequeue();
                foreach (string nextStatus in Get(status)) {
                    if (!seen.Contains(nextStatus)) {
                        if ("123450".Equals(nextStatus)) {
                            return step;
                        }
                        queue.Enqueue(nextStatus);
                        seen.Add(nextStatus);
                    }
                }
            }
        }

        return -1;
    }
    
    public IList<string> Get(string status) {
        IList<string> ret = new List<string>();
        char[] array = status.ToCharArray();
        int x = status.IndexOf('0');
        foreach (int y in neighbors[x]) {
            Swap(array, x, y);
            ret.Add(new string(array));
            Swap(array, x, y);
        }
        return ret;
    }

    public void Swap(char[] array, int x, int y) {
        char temp = array[x];
        array[x] = array[y];
        array[y] = temp;
    }
}