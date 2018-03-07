using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SurroundedRegions
    {
        public void Solve(char[,] board)
        {
            HashSet<KeyValuePair<int, int>> useSet = new HashSet<KeyValuePair<int, int>>(new KVPCompare());

            int maxRowIndex = board.GetLength(0) - 1;
            int maxColumnIndex = board.GetLength(1) - 1;


            for (int i = 0; i <= maxColumnIndex; i++)
            {
                AddSet(board, useSet, 0, i);
                AddSet(board, useSet, maxRowIndex, i);
            }


            for (int i = 0; i <= maxRowIndex; i++)
            {
                AddSet(board, useSet, i,0);
                AddSet(board, useSet, i, maxColumnIndex);
            }

            for (int row = 1; row < maxRowIndex; row++)
            {
                for (int column = 1; column < maxColumnIndex; column++)
                {
                    if (board[row,column] == 'O' && !useSet.Contains(new KeyValuePair<int,int>(row,column)))
                    {
                        board[row, column] = 'X';
                    }
                }
            }

            return;

        }

        private void AddSet(char[,] board, HashSet<KeyValuePair<int, int>> useSet,int rowIndex, int columnIndex)
        {
            if (board[rowIndex, columnIndex] == 'O' && !useSet.Contains(new KeyValuePair<int, int>(rowIndex, columnIndex)))
            {
                HashSet<KeyValuePair<int, int>> tempSet = new HashSet<KeyValuePair<int, int>>(new KVPCompare());
                FindLoop(board, rowIndex, columnIndex, tempSet);
                foreach (var oneValue in tempSet)
                {
                    useSet.Add(oneValue);
                }
            }
        }


        private void FindLoop(char[,] board,int inputRowIndex,int inputColumnIndex,HashSet<KeyValuePair<int, int>> vistedSet)
        {
            vistedSet.Add(new KeyValuePair<int, int>(inputRowIndex, inputColumnIndex));

            if (inputRowIndex - 1 >= 0 && board[inputRowIndex - 1,inputColumnIndex] == 'O' && !vistedSet.Contains(new KeyValuePair<int,int>(inputRowIndex - 1,inputColumnIndex)))
            {
                FindLoop(board, inputRowIndex - 1, inputColumnIndex, vistedSet);
            }

            if (inputRowIndex + 1 < board.GetLength(0) && board[inputRowIndex + 1, inputColumnIndex] == 'O' && !vistedSet.Contains(new KeyValuePair<int, int>(inputRowIndex + 1, inputColumnIndex)))
            {
                FindLoop(board, inputRowIndex + 1, inputColumnIndex, vistedSet);
            }

            if (inputColumnIndex - 1 >= 0 && board[inputRowIndex, inputColumnIndex - 1] == 'O' && !vistedSet.Contains(new KeyValuePair<int, int>(inputRowIndex, inputColumnIndex -1)))
            {
                FindLoop(board, inputRowIndex, inputColumnIndex -1, vistedSet);
            }

            if (inputColumnIndex + 1 < board.GetLength(1) && board[inputRowIndex, inputColumnIndex +1] == 'O' && !vistedSet.Contains(new KeyValuePair<int, int>(inputRowIndex, inputColumnIndex +1)))
            {
                FindLoop(board, inputRowIndex, inputColumnIndex+1, vistedSet);
            }
        }

        private class KVPCompare:IEqualityComparer<KeyValuePair<int,int>>
        {

            public bool Equals(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return x.Key == y.Key && x.Value == y.Value;
            }

            public int GetHashCode(KeyValuePair<int, int> obj)
            {
                return obj.Key + obj.Value;
            }
        }
    }
}
