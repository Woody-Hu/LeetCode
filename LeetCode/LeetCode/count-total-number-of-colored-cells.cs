using System;
namespace LeetCode
{
	public class count_total_number_of_colored_cells
	{
        public long ColoredCells(int n)
        {
            return 1L + (long)2 * n * (n - 1);
        }
    }
}

