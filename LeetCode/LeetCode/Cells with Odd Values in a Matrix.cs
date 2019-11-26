using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Cells_with_Odd_Values_in_a_Matrix
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            int[] rows = new int[n];
            int[] cols = new int[m];
            foreach (var indice in indices)
            {
                rows[indice[0]]++;
                cols[indice[1]]++;
            }

            int row_odd = 0;
            int row_even = 0;
            int col_odd = 0;
            int col_even = 0;
            foreach (var row in rows)
            {
                if (row % 2 == 0)
                {
                    row_even++;
                }
                else
                {
                    row_odd++;
                }
            }

            foreach (var col in cols)
            {
                if (col % 2 == 0)
                {
                    col_even++;
                }
                else
                {
                    col_odd++;
                }
            }


            return row_odd * m - col_odd * row_odd + row_even * m - col_even * row_even;
        }
    }
}
