using System;
namespace LeetCode
{
    public class Determine_Color_of_a_Chessboard_Square
    {
        public bool SquareIsWhite(string coordinates)
        {
            var columnKind = (coordinates[0] - 'a') % 2;
            var rowKind = (coordinates[1] - '0') % 2;
            if (columnKind == 0 && rowKind == 1)
            {
                return false;
            }
            else if (columnKind == 0 && rowKind == 0)
            {
                return true;
            }
            else if (columnKind == 1 && rowKind == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
