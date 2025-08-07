namespace LeetCode;

public class magic_index_lcci
{
    public int FindMagicIndex(int[] nums) {
        int n = nums.Length;
        for (int i = 0; i < n; ++i) {
            if (nums[i] == i) {
                return i; 
            }
        }
        return -1; 
    }
        
    
}