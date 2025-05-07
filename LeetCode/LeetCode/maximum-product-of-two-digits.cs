namespace LeetCode;

public class maximum_product_of_two_digits
{
    public int MaxProduct(int n) {
        int first = int.MinValue, second = int.MinValue;
        while (n > 0) {
            int digit = n % 10;
            if (digit > first) {
                second = first;
                first = digit;
            } else if (digit > second) {
                second = digit;
            }
            n /= 10;
        }
        return first * second;
    }
}