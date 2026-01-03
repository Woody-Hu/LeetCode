using System.Linq;

namespace LeetCode;

public class vowels_game_in_a_string
{
    public bool DoesAliceWin(string s) {
        return s.Any(c => "aeiou".Contains(c));
    }
}