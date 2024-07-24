using System;

namespace LeetCode;

public class find_the_winning_player_in_coin_game
{
    public string LosingPlayer(int x, int y) {
        return Math.Min(x,y/4) % 2 == 0 ? "Bob" : "Alice";
    }
}