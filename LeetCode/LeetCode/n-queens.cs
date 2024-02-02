using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class n_queens
	{
        IList<IList<string>> solutions = new List<IList<string>>();
        int n;
        int[] queens;

        public IList<IList<string>> SolveNQueens(int n)
        {
            this.n = n;
            this.queens = new int[n];
            Array.Fill(queens, -1);
            ISet<int> columnSet = new HashSet<int>();
            ISet<int> diagonal1Set = new HashSet<int>();
            ISet<int> diagonal2Set = new HashSet<int>();
            Backtrack(0, columnSet, diagonal1Set, diagonal2Set);
            return solutions;
        }

        public void Backtrack(int row, ISet<int> columnSet, ISet<int> diagonal1Set, ISet<int> diagonal2Set)
        {
            if (row == n)
            {
                solutions.Add(GetSolution());
            }
            else
            {
                for (int column = 0; column < n; column++)
                {
                    int diagonal1 = row - column, diagonal2 = row + column;
                    if (columnSet.Contains(column) || diagonal1Set.Contains(diagonal1) || diagonal2Set.Contains(diagonal2))
                    {
                        continue;
                    }
                    queens[row] = column;
                    columnSet.Add(column);
                    diagonal1Set.Add(diagonal1);
                    diagonal2Set.Add(diagonal2);
                    Backtrack(row + 1, columnSet, diagonal1Set, diagonal2Set);
                    queens[row] = -1;
                    columnSet.Remove(column);
                    diagonal1Set.Remove(diagonal1);
                    diagonal2Set.Remove(diagonal2);
                }
            }
        }

        public IList<string> GetSolution()
        {
            IList<string> solution = new List<string>();
            for (int i = 0; i < n; i++)
            {
                char[] arr = new char[n];
                Array.Fill(arr, '.');
                arr[queens[i]] = 'Q';
                solution.Add(new string(arr));
            }
            return solution;
        }

        public int BitCount(int num)
        {
            num = num - ((num >> 1) & 0x55555555);
            num = (num & 0x33333333) + ((num >> 2) & 0x33333333);
            num = (num + (num >> 4)) & 0x0f0f0f0f;
            num = num + (num >> 8);
            num = num + (num >> 16);
            return num & 0x3f;
        }
	}
}

