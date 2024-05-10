using System;

namespace LeetCode;

public class calculate_amount_paid_in_taxes
{
    public double CalculateTax(int[][] brackets, int income) {
        var totalTax = 0.0d;
        var lower = 0;
        foreach (var bracket in brackets)
        {
            var upper = bracket[0];
            var rate = bracket[1];
            var tax = (Math.Min(income, upper) - lower) * rate;
            totalTax += tax;
            if (income <= upper)
            {
                break;
            }
            
            lower = upper;
        }
        
        return totalTax / 100.0d;

    }
}