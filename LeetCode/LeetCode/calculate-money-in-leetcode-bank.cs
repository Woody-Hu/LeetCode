namespace LeetCode;

public class calculate_money_in_leetcode_bank
{
    public int TotalMoney(int n) {
        var weekNumber = n / 7;
        var firstWeekMoney = (1 + 7) * 7 / 2;
        var lastWeekMoney = firstWeekMoney + 7 * (weekNumber - 1);
        var weekMoney = (firstWeekMoney + lastWeekMoney) * weekNumber / 2;
        var dayNumber = n % 7;
        var firstDayMoney = 1 + weekNumber;
        var lastDayMoney = firstDayMoney + dayNumber - 1;
        var dayMoney = (firstDayMoney + lastDayMoney) * dayNumber / 2;
        return weekMoney + dayMoney;
    }
}