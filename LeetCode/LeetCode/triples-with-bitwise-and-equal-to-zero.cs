namespace LeetCode;

public class triples_with_bitwise_and_equal_to_zero
{
    public int CountTriplets(int[] nums) {
        int[] cnt = new int[1 << 16];
        foreach (int x in nums) {
            foreach (int y in nums) {
                ++cnt[x & y];
            }
        }
        int ans = 0;
        foreach (int x in nums) {
            for (int mask = 0; mask < (1 << 16); ++mask) {
                if ((x & mask) == 0) {
                    ans += cnt[mask];
                }
            }
        }
        return ans;
    }
}