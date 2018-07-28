using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ConstructQuadTree
    {
        public QuadTreeNode Construct(int[][] grid)
        {
            return InnerMethod(0,0,grid.GetLength(0)-1,grid[0].GetLength(0)-1,grid);
        }

        private QuadTreeNode InnerMethod(int inputRowStart,int inputColumnStart,int inputRowEnd,int inputColumnEnd,int[][] grid)
        {
            if (inputRowStart > inputRowEnd || inputColumnStart > inputColumnEnd)
                return null;

            bool ifIsLeaf = true;

            var tempValue = grid[inputRowStart][inputColumnStart];

            for (int i = inputRowStart; i <= inputRowEnd; i++)
            {
                for (int j = inputColumnStart; j <= inputColumnEnd; j++)
                {
                    if (tempValue != grid[i][j])
                    {
                        ifIsLeaf = false;
                        break;
                    }
                }
            }

            if (ifIsLeaf)
            {
                return new QuadTreeNode(tempValue == 1, true, null, null, null, null);
            }

            int rowMid = (inputRowStart + inputRowEnd) / 2;
            int columnMid = (inputColumnStart + inputColumnEnd) / 2;

            return new QuadTreeNode(false, false, InnerMethod(inputRowStart, inputColumnStart, rowMid, columnMid, grid),
                InnerMethod(inputRowStart, columnMid + 1, rowMid, inputColumnEnd, grid),
                InnerMethod(rowMid + 1, inputColumnStart, inputRowEnd, columnMid, grid),
                InnerMethod(rowMid + 1, columnMid + 1, inputRowEnd, inputColumnEnd, grid)
                );
        }
    }
}
