namespace LeetCode;

public class check_balanced_string
{
    public bool IsBalanced(string num)
    {
        var evenSum = 0;
        var oddSum = 0;
        var length = num.Length;
        for (var i = 0; i < length; i++) {
            var digit = num[i] - '0';
            if (i % 2 == 0) {
                evenSum += digit;
            } else {
                oddSum += digit;
            }
        }
        
        return evenSum == oddSum;
    }
}