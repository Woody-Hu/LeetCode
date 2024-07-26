using System.Collections.Generic;

namespace LeetCode;

public class minimum_number_of_flips_to_convert_binary_matrix_to_zero_matrix
{
    const int TARGET = 0;
    static int[][] dirs = {new int[]{-1, 0}, new int[]{1, 0}, new int[]{0, -1}, new int[]{0, 1}};
    int m, n;
    
    public int MinFlips(int[][] mat) {
        m = mat.Length;
        n = mat[0].Length;
        int startState = 0;
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                startState += mat[i][j] << GetIndex(i, j);
            }
        }
        
        ISet<int> visited = new HashSet<int>();
        visited.Add(startState);
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(startState);
        int flips = -1;
        while (queue.Count > 0) {
            flips++;
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                int state = queue.Dequeue();
                if (state == TARGET) {
                    return flips;
                }
                for (int j = 0; j < m; j++) {
                    for (int k = 0; k < n; k++) {
                        int adjacentState = GetAdjacentState(state, j, k);
                        if (visited.Add(adjacentState)) {
                            queue.Enqueue(adjacentState);
                        }
                    }
                }
            }
        }
        return -1;
    }

    public int GetAdjacentState(int state, int row, int col) {
        state ^= 1 << GetIndex(row, col);
        foreach (int[] dir in dirs) {
            int newRow = row + dir[0], newCol = col + dir[1];
            if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n) {
                state ^= 1 << GetIndex(newRow, newCol);
            }
        }
        return state;
    }

    public int GetIndex(int row, int col) {
        return row * n + col;
    }
}