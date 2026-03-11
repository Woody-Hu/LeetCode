namespace LeetCode;

public class find_the_score_difference_in_a_game
{
    public int ScoreDifference(int[] nums) {
        int[] scores = new int[2];
        int activePlayer = 0;
        int gamesCount = 0;
        foreach (int num in nums) {
            gamesCount++;
            if (num % 2 != 0) {
                activePlayer ^= 1;
            }
            if (gamesCount % 6 == 0) {
                activePlayer ^= 1;
            }
            scores[activePlayer] += num;
        }
        return scores[0] - scores[1];
    }
}