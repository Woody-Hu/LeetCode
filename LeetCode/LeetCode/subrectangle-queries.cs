using System;
namespace LeetCode
{
    public class subrectangle_queries
    {
        public class SubrectangleQueries
        {
            private int[][] _data;

            public SubrectangleQueries(int[][] rectangle)
            {
                _data = rectangle;
            }

            public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
            {
                for (int i = row1; i <= row2; i++)
                {
                    for (int j = col1; j <= col2; j++)
                    {
                        _data[i][j] = newValue;
                    }
                }
            }

            public int GetValue(int row, int col)
            {
                return _data[row][col];
            }
        }
    }
}
