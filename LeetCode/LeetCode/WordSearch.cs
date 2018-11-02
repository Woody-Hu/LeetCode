using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class WordSearch
    {
        public bool Exist(char[,] board, string word)
        {
            bool[,] visited = new bool[board.GetLength(0),board.GetLength(1)];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (ExistCheck(board,word,0,i,j, visited))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ExistCheck(char[,] board, string word, int charIndex, int row, int column, bool[,] visited)
        {
            if (charIndex == word.Length)
            {
                return true;
            }

            if (row<0||column <0 ||row == board.GetLength(0)||column == board.GetLength(1))
            {
                return false;
            }

            if (visited[row,column])
            {
                return false;
            }

            if (board[row,column]!=word[charIndex])
            {
                return false;
            }

            visited[row, column] = true;

            var returnValue = ExistCheck(board, word, charIndex + 1, row - 1, column, visited) ||
                              ExistCheck(board, word, charIndex + 1, row + 1, column, visited) ||
                              ExistCheck(board, word, charIndex + 1, row, column - 1, visited) ||
                              ExistCheck(board, word, charIndex + 1, row, column + 1, visited);

            visited[row, column] = false;

            return returnValue;
        }
    }
}
