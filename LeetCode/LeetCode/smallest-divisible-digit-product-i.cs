namespace LeetCode;

public class smallest_divisible_digit_product_i
{
    public int SmallestNumber(int n, int t) {
        while (DigitProduct(n) % t != 0) {
            n++;
        }
        
        return n;
    }
    
    private int DigitProduct(int x) {
        var product = 1;
        while (x> 0 && product > 0) {
            product *= x % 10;
            x /= 10;
        }
        return product;
    }
}