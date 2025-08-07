namespace LeetCode;

public class exchange_lcci
{
    public int ExchangeBits(int num) {
        long evenBits = num & 0xAAAAAAAA; 
        int oddBits = num & 0x55555555;  
        
        evenBits >>= 1; 
        oddBits <<= 1;  
        
        return (int)evenBits | oddBits; 
    }
}