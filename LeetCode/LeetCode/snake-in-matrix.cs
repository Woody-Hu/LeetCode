using System.Collections.Generic;

namespace LeetCode;

public class snake_in_matrix
{
    public int FinalPositionOfSnake(int n, IList<string> commands)
    {
        var x = 0;
        var y = 0;
        foreach (var command in commands)
        {
            if (command[0] == 'U')
            {
                x--;
            }
            else if (command[0] == 'D')
            {
                x++;
            }
            else if (command[0] == 'L')
            {
                y--;
            }
            else
            {
                y++;
            }
        }

        return x * n + y;

    }
}