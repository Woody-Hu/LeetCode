namespace LeetCode;

public class minimum_number_of_operations_to_convert_time
{
    public int ConvertTime(string current, string correct) {
        var currentMinutes = int.Parse(current.Substring(0, 2)) * 60 + int.Parse(current.Substring(3, 2));
        var correctMinutes = int.Parse(correct.Substring(0, 2)) * 60 + int.Parse(correct.Substring(3, 2));
        var diff = correctMinutes - currentMinutes;
        var ops = new int[] { 60, 15, 5, 1 };
        var result = 0;
        foreach (var op in ops) {
            result += diff / op;
            diff %= op;
        }
        
        return result;
    }
}