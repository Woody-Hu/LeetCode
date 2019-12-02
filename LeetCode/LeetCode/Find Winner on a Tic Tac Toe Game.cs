using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Find_Winner_on_a_Tic_Tac_Toe_Game
    {
        public string Tictactoe(int[][] moves)
        {
            var a = new int[8];
            var b = new int[8];

            for (int i = 0; i < moves.Length; i++)
            {
                int r = moves[i][0], c = moves[i][1];
                var use = i % 2 == 0 ? a : b;
                use[r]++;
                use[c + 3]++;
                if (r == c) use[6]++;
                if (r == 2 - c) use[7]++;
            }

            for (int i = 0; i < 8; i++)
            {
                if (a[i] == 3 )
                {
                    return "A";
                }
                else if (b[i] == 3)
                {
                    return "B";
                }
            }

            if (moves.Length == 9)
            {
                return "Draw";
            }

            return "Pending";
        }
    }
}
