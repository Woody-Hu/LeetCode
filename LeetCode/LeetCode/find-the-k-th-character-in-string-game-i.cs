namespace LeetCode;

public class find_the_k_th_character_in_string_game_i
{
    public char KthCharacter(int k) {
        int binaryLength = GetBinaryLength(k - 1);
        return FindCharacter(k, binaryLength - 1);
    }

    private int GetBinaryLength(long num) {
        int length = 0;
        while (num > 0) {
            num /= 2;
            length++;
        }
        return length;
    }

    private char FindCharacter(long k, int index) {
        if (index < 0) {
            return 'a';
        }
        long prevPosition = 1L << index;
        if (k <= prevPosition) {
            return FindCharacter(k, index - 1);
        } else {
            char prev = FindCharacter(k - prevPosition, index - 1);
            return (char) (prev + 1);
        }
    }
}