namespace LeetCode;

public class check_divisibility_by_digit_sum_and_product
{
    public bool CheckDivisibility(int n) {
        return n % GetSum(n) == 0;
    }

    public int GetSum(int n) {
        int digitSum = 0, digitProduct = 1;
        while (n > 0) {
            int digit = n % 10;
            digitSum += digit;
            digitProduct *= digit;
            n /= 10;
        }
        return digitSum + digitProduct;
    }
}