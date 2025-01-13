namespace LeetCode;

public class largest_3_same_digit_number_in_string
{
    public string LargestGoodInteger(string num) {
        int n = num.Length;
        string res = "";
        for (int i = 0; i < n - 2; i++) {
            if (num[i] == num[i + 1] && num[i + 1] == num[i + 2]) {
                string current = num.Substring(i, 3);
                if (string.Compare(current, res) > 0) {
                    res = current;
                }
            }
        }
        return res;
    }
}