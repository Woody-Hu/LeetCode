namespace LeetCode;

public class number_of_bit_changes_to_make_two_integers_equal
{
    public int MinChanges(int n, int k) {
        return (n & k) == k ? BitCount(n ^ k) : -1;
    }
    
    private int BitCount(int x) {
        x = (x & 0x55555555) + ((x >> 1) & 0x55555555);
        x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
        x = (x & 0x0F0F0F0F) + ((x >> 4) & 0x0F0F0F0F);
        x = (x & 0x00FF00FF) + ((x >> 8) & 0x00FF00FF);
        x = (x & 0x0000FFFF) + ((x >> 16) & 0x0000FFFF);
        return x;
    }
}