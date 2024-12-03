using System.Collections.Generic;

namespace LeetCode;

public class sudoku_solver
{
    char[][] board;
    bool[][] rows = new bool[9][];
    bool[][] columns = new bool[9][];
    bool[][] subboxes = new bool[9][];
    IList<int[]> emptyCells = new List<int[]>();
    bool solved = false;

    public void SolveSudoku(char[][] board) {
        this.board = board;
        for (int i = 0; i < 9; i++) {
            this.rows[i] = new bool[10];
            this.columns[i] = new bool[10];
            this.subboxes[i] = new bool[10];
        }
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char c = board[i][j];
                if (c == '.') {
                    emptyCells.Add(new int[]{i, j});
                } else {
                    int subboxRowIndex = i / 3, subboxColumnIndex = j / 3;
                    int subboxIndex = subboxRowIndex * 3 + subboxColumnIndex;
                    int digit = c - '0';
                    rows[i][digit] = true;
                    columns[j][digit] = true;
                    subboxes[subboxIndex][digit] = true;
                }
            }
        }
        Backtrack(0);
    }

    public void Backtrack(int cellIndex) {
        if (cellIndex == emptyCells.Count) {
            solved = true;
        } else {
            int[] cell = emptyCells[cellIndex];
            int rowIndex = cell[0], columnIndex = cell[1];
            int subboxRowIndex = rowIndex / 3, subboxColumnIndex = columnIndex / 3;
            int subboxIndex = subboxRowIndex * 3 + subboxColumnIndex;
            for (int digit = 1; digit <= 9; digit++) {
                if (!rows[rowIndex][digit] && !columns[columnIndex][digit] && !subboxes[subboxIndex][digit]) {
                    board[rowIndex][columnIndex] = (char) ('0' + digit);
                    rows[rowIndex][digit] = true;
                    columns[columnIndex][digit] = true;
                    subboxes[subboxIndex][digit] = true;
                    Backtrack(cellIndex + 1);
                    if (!solved) {
                        board[rowIndex][columnIndex] = '.';
                        rows[rowIndex][digit] = false;
                        columns[columnIndex][digit] = false;
                        subboxes[subboxIndex][digit] = false;
                    }
                }
            }
        }
    }
}