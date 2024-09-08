using System;

namespace LeetCode;

public class convert_date_to_binary
{
    public string ConvertDateToBinary(string date) {
        var dateParts = date.Split("-");
        var year = Convert.ToString(int.Parse(dateParts[0]), 2);
        var month = Convert.ToString(int.Parse(dateParts[1]), 2);
        var day = Convert.ToString(int.Parse(dateParts[2]), 2);
        return $"{year}-{month}-{day}";

    }
}