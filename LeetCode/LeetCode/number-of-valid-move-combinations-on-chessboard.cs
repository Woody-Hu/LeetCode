using System.Collections.Generic;

namespace LeetCode;

public class number_of_valid_move_combinations_on_chessboard
{
    static int[][] rookDirections = {new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1}};
    static int[][] bishopDirections = {new int[]{1, 1}, new int[]{1, -1}, new int[]{-1, 1}, new int[]{-1, -1}};
    static int[][] queenDirections = {new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1}, new int[]{1, 1}, new int[]{1, -1}, new int[]{-1, 1}, new int[]{-1, -1}};
    string[] pieces;
    int[][] positions;
    int n;
    int res = 0;
    IList<Movement> stack = new List<Movement>();

    public int CountCombinations(string[] pieces, int[][] positions) {
        this.pieces = pieces;
        this.positions = positions;
        this.n = pieces.Length;
        DFS(0);
        return res;
    }

    public void DFS(int u) {
        if (u == n) {
            res++;
            return;
        }
        int[][] directions;
        if (pieces[u] == "rook") {
            directions = rookDirections;
        } else if (pieces[u] == "queen") {
            directions = queenDirections;
        } else {
            directions = bishopDirections;
        }
        
        stack.Add(new Movement(positions[u][0], positions[u][1], positions[u][0], positions[u][1], 0, 0));
        if (Check(u)) {
            DFS(u + 1);
        }
        stack.RemoveAt(stack.Count - 1);
        
        for (int i = 0; i < directions.Length; i++) {
            for (int j = 1; j < 8; j++) {
                int x = positions[u][0] + directions[i][0] * j;
                int y = positions[u][1] + directions[i][1] * j;
                if (x < 1 || x > 8 || y < 1 || y > 8) {
                    break;
                }
                stack.Add(new Movement(positions[u][0], positions[u][1], x, y, directions[i][0], directions[i][1]));
                if (Check(u)) {
                    DFS(u + 1);
                }
                stack.RemoveAt(stack.Count - 1);
            }
        }
    }
    
    public bool Check(int u) {
        for (int v = 0; v < u; v++) {
            if (stack[u].Cross(stack[v])) {
                return false;
            }
        }
        return true;
    }
}

class Movement {
    public int startX;
    public int startY;
    public int endX;
    public int endY;
    public int dx;
    public int dy;
    public int curX;
    public int curY;

    public Movement(int startX, int startY, int endX, int endY, int dx, int dy) {
        this.startX = startX;
        this.startY = startY;
        this.endX = endX;
        this.endY = endY;
        this.dx = dx;
        this.dy = dy;
        this.curX = startX;
        this.curY = startY;
    }

    public void Reset() {
        curX = startX;
        curY = startY;
    }

    public bool Stopped() {
        return curX == endX && curY == endY;
    }

    public void Advance() {
        if (!Stopped()) {
            curX += dx;
            curY += dy;
        }
    }

    public bool Cross(Movement oth) {
        Reset();
        oth.Reset();
        while (!Stopped() || !oth.Stopped()) {
            Advance();
            oth.Advance();
            if (curX == oth.curX && curY == oth.curY) {
                return true;
            }
        }
        return false;
    }
}